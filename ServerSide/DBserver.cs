﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ServerSide
{
    public sealed class DBserver
    {
        private static readonly DBserver instance = new DBserver();
        System.Data.SQLite.SQLiteConnection m_dbConnection;
        public String DB = "";
        public List<Client> Allclients = new List<Client>();
        
        static DBserver()
        {
        }
        private DBserver()
        {
            DB = "DBServer.sqlite";
            createNewDatabase();
            connectToDatabase();
            createClientsTable();
            createTriggersTable();

        }
      
        public static DBserver Instance
            {
                get
                {
                    return instance;
                }
            }
       
        public int createNewDatabase()
        {
            string projectDirectory = Environment.CurrentDirectory;
            //string path = Directory.GetParent(projectDirectory).Parent.FullName;

            var dbPath = Path.Combine(projectDirectory, DB);
           
            if (File.Exists(dbPath))
                return 1;
            else
                SQLiteConnection.CreateFile(dbPath);
            return 0;
        }
    
        public static void ShowErrorDialog(string message)
    {
        MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

        // Creates a connection with our database file.
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + DB + ";Version=3;");
            m_dbConnection.Open();
        }

        // Creates a table named 'clientData' with two columns: name (a string of max 20 characters) and score (an int)
        public void createClientsTable()
        {
            //string sql = "create table clientData (name varchar(20), settingString varchar(20))";
            string sql = "CREATE TABLE IF NOT EXISTS clientData(id INTEGER PRIMARY KEY,name TEXT, settingString TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }

        // Inserts some values in the clientData table. 
        public void fillClientsTable(int id1, string name1, string settingString1)
        {
            
            string sql = "insert or replace into clientData (id,name,settingString) values('" + id1 + "','" + name1 + "','" + settingString1 + "');";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        internal List<Client> initialServer()
        {
            List<Client> Allclients = new List<Client>();
        
                string s = "";
                string id = "";
                string name = "";
                string sql = "select * from clientData ";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //s += "id: " + reader["id"] + "\tname: " + reader["name"] + "\n";
                    //ShowErrorDialog(s);
                    name = "" + reader["name"];
                    id = "" + reader["id"];
                    Client newClient = new Client(name, int.Parse(id), null, null);
                    Allclients.Add(newClient);
                }
                
         
            return Allclients;
        }

        public void createTriggersTable()
        {
            //string sql = "create table clientData (name varchar(20), settingString varchar(20))";
            string sql = "create table  IF NOT EXISTS TriggersTable(clientId int ,trigerId int, triggerDate TEXT, triggerDes TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void fillTriggersTable(int clientId, int trigerId, string triggerDate, string triggerDes)
        {
            string sql = "insert into TriggersTable (clientId,trigerId,triggerDate,triggerDes) values('" + clientId + "','" + trigerId + "','" + triggerDate + "','" + triggerDes + "');";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            
        }

        public void removeClientFromDB(string id)
        {
                try
                {
                    string sql = "DELETE FROM clientData  WHERE id='" + id + "'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex) {

                    ShowErrorDialog("removeClientFromDB: "+ ex);
                }
       
         
        }
    
        public string getSttingById(int id) {

        string s = "";
        string sql = "select  *  from  clientData where id='" + id + "'";
        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            s += reader["settingString"];
        }



        return s;
    }
    }
}

