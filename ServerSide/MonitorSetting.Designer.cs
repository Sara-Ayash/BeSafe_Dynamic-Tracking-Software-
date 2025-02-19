﻿namespace ServerSide
{
    partial class MonitorSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorSetting));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbAppInstallUpdate = new System.Windows.Forms.CheckBox();
            this.chbAppInstallReport = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtgCategorySites = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportImmediately = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUnblockedSites = new System.Windows.Forms.TextBox();
            this.chbBadWordUpdate = new System.Windows.Forms.CheckBox();
            this.chbBadWordReport = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chblFrequency = new System.Windows.Forms.CheckedListBox();
            this.txbBlockedSites = new System.Windows.Forms.TextBox();
            this.btnAddSiteToCancelMonitoring = new System.Windows.Forms.Button();
            this.btnAddSiteToMonitoring = new System.Windows.Forms.Button();
            this.txbAddBadWords = new System.Windows.Forms.TextBox();
            this.btnAddBadWords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMinuteReport = new System.Windows.Forms.NumericUpDown();
            this.lblallBadWord = new System.Windows.Forms.Label();
            this.lblUnBlockSites = new System.Windows.Forms.Label();
            this.lblBadWords = new System.Windows.Forms.Label();
            this.btnShowBlockedSites = new System.Windows.Forms.Button();
            this.btnShowUnBlockedSites = new System.Windows.Forms.Button();
            this.btnShowBadWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorySites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(112, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blocking Sites  By Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(110, 645);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Limit application installation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chbAppInstallUpdate
            // 
            this.chbAppInstallUpdate.AutoSize = true;
            this.chbAppInstallUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbAppInstallUpdate.Location = new System.Drawing.Point(137, 678);
            this.chbAppInstallUpdate.Name = "chbAppInstallUpdate";
            this.chbAppInstallUpdate.Size = new System.Drawing.Size(134, 24);
            this.chbAppInstallUpdate.TabIndex = 0;
            this.chbAppInstallUpdate.Text = "Update report";
            this.chbAppInstallUpdate.UseVisualStyleBackColor = false;
            // 
            // chbAppInstallReport
            // 
            this.chbAppInstallReport.AutoSize = true;
            this.chbAppInstallReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbAppInstallReport.Location = new System.Drawing.Point(291, 678);
            this.chbAppInstallReport.Name = "chbAppInstallReport";
            this.chbAppInstallReport.Size = new System.Drawing.Size(171, 24);
            this.chbAppInstallReport.TabIndex = 0;
            this.chbAppInstallReport.Text = "Report immediately";
            this.chbAppInstallReport.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 902);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Set frequency to get Report:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOK.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.ForeColor = System.Drawing.Color.Lime;
            this.btnOK.Location = new System.Drawing.Point(117, 1127);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(312, 54);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Set Setting";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtgCategorySites
            // 
            this.dtgCategorySites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategorySites.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCategorySites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorySites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.ReportImmediately,
            this.UpdateReport});
            this.dtgCategorySites.Location = new System.Drawing.Point(113, 296);
            this.dtgCategorySites.Name = "dtgCategorySites";
            this.dtgCategorySites.RowHeadersVisible = false;
            this.dtgCategorySites.RowHeadersWidth = 200;
            this.dtgCategorySites.RowTemplate.Height = 28;
            this.dtgCategorySites.Size = new System.Drawing.Size(1049, 168);
            this.dtgCategorySites.TabIndex = 8;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "News";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            // 
            // ReportImmediately
            // 
            this.ReportImmediately.HeaderText = "Report immediately";
            this.ReportImmediately.MinimumWidth = 8;
            this.ReportImmediately.Name = "ReportImmediately";
            // 
            // UpdateReport
            // 
            this.UpdateReport.HeaderText = "Update report";
            this.UpdateReport.MinimumWidth = 8;
            this.UpdateReport.Name = "UpdateReport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(112, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Please Add Sites To Cancel Monitoring:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(110, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please Add bad words To Monitoring";
            // 
            // txbUnblockedSites
            // 
            this.txbUnblockedSites.Location = new System.Drawing.Point(113, 596);
            this.txbUnblockedSites.Name = "txbUnblockedSites";
            this.txbUnblockedSites.Size = new System.Drawing.Size(507, 26);
            this.txbUnblockedSites.TabIndex = 13;
            // 
            // chbBadWordUpdate
            // 
            this.chbBadWordUpdate.AutoSize = true;
            this.chbBadWordUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbBadWordUpdate.Location = new System.Drawing.Point(137, 760);
            this.chbBadWordUpdate.Name = "chbBadWordUpdate";
            this.chbBadWordUpdate.Size = new System.Drawing.Size(134, 24);
            this.chbBadWordUpdate.TabIndex = 0;
            this.chbBadWordUpdate.Text = "Update report";
            this.chbBadWordUpdate.UseVisualStyleBackColor = false;
            // 
            // chbBadWordReport
            // 
            this.chbBadWordReport.AutoSize = true;
            this.chbBadWordReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbBadWordReport.Location = new System.Drawing.Point(291, 760);
            this.chbBadWordReport.Name = "chbBadWordReport";
            this.chbBadWordReport.Size = new System.Drawing.Size(171, 24);
            this.chbBadWordReport.TabIndex = 0;
            this.chbBadWordReport.Text = "Report immediately";
            this.chbBadWordReport.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(110, 727);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Typing inappropriate words";
            this.label14.Click += new System.EventHandler(this.label5_Click);
            // 
            // chblFrequency
            // 
            this.chblFrequency.CheckOnClick = true;
            this.chblFrequency.FormattingEnabled = true;
            this.chblFrequency.Items.AddRange(new object[] {
            "Each Day",
            "Each Week",
            "Two once each week",
            "Each Month"});
            this.chblFrequency.Location = new System.Drawing.Point(149, 932);
            this.chblFrequency.Name = "chblFrequency";
            this.chblFrequency.Size = new System.Drawing.Size(200, 96);
            this.chblFrequency.TabIndex = 14;
            this.chblFrequency.SelectedIndexChanged += new System.EventHandler(this.chblFrequency_SelectedIndexChanged);
            // 
            // txbBlockedSites
            // 
            this.txbBlockedSites.Location = new System.Drawing.Point(114, 516);
            this.txbBlockedSites.Name = "txbBlockedSites";
            this.txbBlockedSites.Size = new System.Drawing.Size(507, 26);
            this.txbBlockedSites.TabIndex = 13;
            // 
            // btnAddSiteToCancelMonitoring
            // 
            this.btnAddSiteToCancelMonitoring.Location = new System.Drawing.Point(635, 596);
            this.btnAddSiteToCancelMonitoring.Name = "btnAddSiteToCancelMonitoring";
            this.btnAddSiteToCancelMonitoring.Size = new System.Drawing.Size(143, 30);
            this.btnAddSiteToCancelMonitoring.TabIndex = 30;
            this.btnAddSiteToCancelMonitoring.Text = "Add Site";
            this.btnAddSiteToCancelMonitoring.UseVisualStyleBackColor = true;
            this.btnAddSiteToCancelMonitoring.Click += new System.EventHandler(this.btnAddSiteToCancelMonitoring_Click);
            // 
            // btnAddSiteToMonitoring
            // 
            this.btnAddSiteToMonitoring.Location = new System.Drawing.Point(639, 512);
            this.btnAddSiteToMonitoring.Name = "btnAddSiteToMonitoring";
            this.btnAddSiteToMonitoring.Size = new System.Drawing.Size(143, 30);
            this.btnAddSiteToMonitoring.TabIndex = 30;
            this.btnAddSiteToMonitoring.Text = "Add Site";
            this.btnAddSiteToMonitoring.UseVisualStyleBackColor = true;
            this.btnAddSiteToMonitoring.Click += new System.EventHandler(this.btnAddSiteToMonitoring_Click);
            // 
            // txbAddBadWords
            // 
            this.txbAddBadWords.Location = new System.Drawing.Point(117, 863);
            this.txbAddBadWords.Name = "txbAddBadWords";
            this.txbAddBadWords.Size = new System.Drawing.Size(260, 26);
            this.txbAddBadWords.TabIndex = 13;
            // 
            // btnAddBadWords
            // 
            this.btnAddBadWords.Location = new System.Drawing.Point(391, 861);
            this.btnAddBadWords.Name = "btnAddBadWords";
            this.btnAddBadWords.Size = new System.Drawing.Size(143, 30);
            this.btnAddBadWords.TabIndex = 30;
            this.btnAddBadWords.Text = "Add Word";
            this.btnAddBadWords.UseVisualStyleBackColor = true;
            this.btnAddBadWords.Click += new System.EventHandler(this.btnAddBadWords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Add Sites To Monitoring:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(392, 1082);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(452, 26);
            this.txbEmail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 1085);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address Mail to get Reorts and Alerts:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 1038);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "send report each                   Minutes";
            // 
            // nudMinuteReport
            // 
            this.nudMinuteReport.Location = new System.Drawing.Point(285, 1035);
            this.nudMinuteReport.Name = "nudMinuteReport";
            this.nudMinuteReport.Size = new System.Drawing.Size(61, 26);
            this.nudMinuteReport.TabIndex = 31;
            // 
            // lblallBadWord
            // 
            this.lblallBadWord.AutoSize = true;
            this.lblallBadWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblallBadWord.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblallBadWord.Location = new System.Drawing.Point(415, 519);
            this.lblallBadWord.Name = "lblallBadWord";
            this.lblallBadWord.Size = new System.Drawing.Size(0, 20);
            this.lblallBadWord.TabIndex = 9;
            // 
            // lblUnBlockSites
            // 
            this.lblUnBlockSites.AutoSize = true;
            this.lblUnBlockSites.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUnBlockSites.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUnBlockSites.Location = new System.Drawing.Point(121, 637);
            this.lblUnBlockSites.Name = "lblUnBlockSites";
            this.lblUnBlockSites.Size = new System.Drawing.Size(0, 20);
            this.lblUnBlockSites.TabIndex = 9;
            // 
            // lblBadWords
            // 
            this.lblBadWords.AutoSize = true;
            this.lblBadWords.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBadWords.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBadWords.Location = new System.Drawing.Point(257, 857);
            this.lblBadWords.Name = "lblBadWords";
            this.lblBadWords.Size = new System.Drawing.Size(0, 20);
            this.lblBadWords.TabIndex = 10;
            // 
            // btnShowBlockedSites
            // 
            this.btnShowBlockedSites.Location = new System.Drawing.Point(796, 512);
            this.btnShowBlockedSites.Name = "btnShowBlockedSites";
            this.btnShowBlockedSites.Size = new System.Drawing.Size(228, 29);
            this.btnShowBlockedSites.TabIndex = 33;
            this.btnShowBlockedSites.Text = "View added blocking sites";
            this.btnShowBlockedSites.UseVisualStyleBackColor = true;
            this.btnShowBlockedSites.Click += new System.EventHandler(this.btnShowBlockedSites_Click);
            // 
            // btnShowUnBlockedSites
            // 
            this.btnShowUnBlockedSites.Location = new System.Drawing.Point(792, 595);
            this.btnShowUnBlockedSites.Name = "btnShowUnBlockedSites";
            this.btnShowUnBlockedSites.Size = new System.Drawing.Size(228, 29);
            this.btnShowUnBlockedSites.TabIndex = 33;
            this.btnShowUnBlockedSites.Text = "View added Unblocking sites";
            this.btnShowUnBlockedSites.UseVisualStyleBackColor = true;
            this.btnShowUnBlockedSites.Click += new System.EventHandler(this.btnShowUnBlockedSites_Click);
            // 
            // btnShowBadWord
            // 
            this.btnShowBadWord.Location = new System.Drawing.Point(543, 861);
            this.btnShowBadWord.Name = "btnShowBadWord";
            this.btnShowBadWord.Size = new System.Drawing.Size(228, 29);
            this.btnShowBadWord.TabIndex = 33;
            this.btnShowBadWord.Text = "View added bad words";
            this.btnShowBadWord.UseVisualStyleBackColor = true;
            this.btnShowBadWord.Click += new System.EventHandler(this.btnShowBadWord_Click);
            // 
            // MonitorSetting
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1415, 1195);
            this.Controls.Add(this.btnShowBadWord);
            this.Controls.Add(this.btnShowUnBlockedSites);
            this.Controls.Add(this.btnShowBlockedSites);
            this.Controls.Add(this.nudMinuteReport);
            this.Controls.Add(this.btnAddBadWords);
            this.Controls.Add(this.btnAddSiteToMonitoring);
            this.Controls.Add(this.btnAddSiteToCancelMonitoring);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbAddBadWords);
            this.Controls.Add(this.chblFrequency);
            this.Controls.Add(this.txbBlockedSites);
            this.Controls.Add(this.txbUnblockedSites);
            this.Controls.Add(this.lblUnBlockSites);
            this.Controls.Add(this.lblallBadWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBadWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgCategorySites);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chbBadWordReport);
            this.Controls.Add(this.chbAppInstallReport);
            this.Controls.Add(this.chbBadWordUpdate);
            this.Controls.Add(this.chbAppInstallUpdate);
            this.HelpButton = true;
            this.Name = "MonitorSetting";
            this.Text = "MonitorSystem";
            this.Load += new System.EventHandler(this.MonitorSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorySites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbAppInstallUpdate;
        private System.Windows.Forms.CheckBox chbAppInstallReport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dtgCategorySites;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUnblockedSites;
        private System.Windows.Forms.CheckBox chbBadWordUpdate;
        private System.Windows.Forms.CheckBox chbBadWordReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox chblFrequency;
        private System.Windows.Forms.TextBox txbBlockedSites;
        private System.Windows.Forms.Button btnAddSiteToCancelMonitoring;
        private System.Windows.Forms.Button btnAddSiteToMonitoring;
        private System.Windows.Forms.TextBox txbAddBadWords;
        private System.Windows.Forms.Button btnAddBadWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReportImmediately;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMinuteReport;
        private System.Windows.Forms.Label lblallBadWord;
        private System.Windows.Forms.Label lblUnBlockSites;
        private System.Windows.Forms.Label lblBadWords;
        private System.Windows.Forms.Button btnShowBlockedSites;
        private System.Windows.Forms.Button btnShowUnBlockedSites;
        private System.Windows.Forms.Button btnShowBadWord;
    }
}