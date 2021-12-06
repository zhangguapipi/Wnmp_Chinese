﻿namespace Wnmp.UI
{
    partial class MainFrm
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.WnmpMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wnmpOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHTTPHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMariaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wnmpDirButton = new System.Windows.Forms.Button();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.applicationsGroupBox = new System.Windows.Forms.GroupBox();
            this.phpRestartButton = new System.Windows.Forms.Button();
            this.mariadbRestartButton = new System.Windows.Forms.Button();
            this.nginxRestartButton = new System.Windows.Forms.Button();
            this.phpLogButton = new System.Windows.Forms.Button();
            this.mariadbLogButton = new System.Windows.Forms.Button();
            this.nginxLogButton = new System.Windows.Forms.Button();
            this.phpConfigButton = new System.Windows.Forms.Button();
            this.mariadbConfigButton = new System.Windows.Forms.Button();
            this.nginxConfigButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phprunning = new System.Windows.Forms.Label();
            this.mariadbrunning = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.nginxrunning = new System.Windows.Forms.Label();
            this.runningLabel = new System.Windows.Forms.Label();
            this.mariadbStopButton = new System.Windows.Forms.Button();
            this.mariadbStartButton = new System.Windows.Forms.Button();
            this.phpStartButton = new System.Windows.Forms.Button();
            this.phpStopButton = new System.Windows.Forms.Button();
            this.nginxStartButton = new System.Windows.Forms.Button();
            this.nginxStopButton = new System.Windows.Forms.Button();
            this.startAllButton = new System.Windows.Forms.Button();
            this.stopAllButton = new System.Windows.Forms.Button();
            this.openMariaDBShellButton = new System.Windows.Forms.Button();
            this.AppsRunningTimer = new System.Windows.Forms.Timer(this.components);
            this.WnmpMenuStrip.SuspendLayout();
            this.applicationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WnmpMenuStrip
            // 
            this.WnmpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.localhostToolStripMenuItem,
            this.setupMariaDBToolStripMenuItem});
            this.WnmpMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.WnmpMenuStrip.Name = "WnmpMenuStrip";
            this.WnmpMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.WnmpMenuStrip.Size = new System.Drawing.Size(755, 25);
            this.WnmpMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wnmpOptionsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // wnmpOptionsToolStripMenuItem
            // 
            this.wnmpOptionsToolStripMenuItem.Name = "wnmpOptionsToolStripMenuItem";
            this.wnmpOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wnmpOptionsToolStripMenuItem.Text = "选项";
            this.wnmpOptionsToolStripMenuItem.Click += new System.EventHandler(this.WnmpOptionsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "检查更新";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToIPToolStripMenuItem,
            this.getHTTPHeadersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // hostToIPToolStripMenuItem
            // 
            this.hostToIPToolStripMenuItem.Name = "hostToIPToolStripMenuItem";
            this.hostToIPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hostToIPToolStripMenuItem.Text = "主机到IP";
            this.hostToIPToolStripMenuItem.Click += new System.EventHandler(this.HostToIPToolStripMenuItem_Click);
            // 
            // getHTTPHeadersToolStripMenuItem
            // 
            this.getHTTPHeadersToolStripMenuItem.Name = "getHTTPHeadersToolStripMenuItem";
            this.getHTTPHeadersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getHTTPHeadersToolStripMenuItem.Text = "获取HTTP头";
            this.getHTTPHeadersToolStripMenuItem.Click += new System.EventHandler(this.GetHTTPHeadersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator2,
            this.websiteToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supportToolStripMenuItem.Text = "社区支持";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.SupportToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportBugToolStripMenuItem.Text = "报告错误";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.ReportBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.websiteToolStripMenuItem.Text = "官网";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donateToolStripMenuItem.Text = "捐献";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.localhostToolStripMenuItem.Text = "本地服务器";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.LocalhostToolStripMenuItem_Click);
            // 
            // setupMariaDBToolStripMenuItem
            // 
            this.setupMariaDBToolStripMenuItem.Name = "setupMariaDBToolStripMenuItem";
            this.setupMariaDBToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.setupMariaDBToolStripMenuItem.Text = "Setup MariaDB";
            this.setupMariaDBToolStripMenuItem.Click += new System.EventHandler(this.setupMariaDBToolStripMenuItem_Click);
            // 
            // wnmpDirButton
            // 
            this.wnmpDirButton.Location = new System.Drawing.Point(667, 212);
            this.wnmpDirButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wnmpDirButton.Name = "wnmpDirButton";
            this.wnmpDirButton.Size = new System.Drawing.Size(74, 52);
            this.wnmpDirButton.TabIndex = 65;
            this.wnmpDirButton.Text = "Wnmp Directory";
            this.wnmpDirButton.UseVisualStyleBackColor = true;
            this.wnmpDirButton.Click += new System.EventHandler(this.WnmpDirButton_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.Color.White;
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logRichTextBox.Location = new System.Drawing.Point(0, 300);
            this.logRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(755, 173);
            this.logRichTextBox.TabIndex = 61;
            this.logRichTextBox.Text = "";
            // 
            // applicationsGroupBox
            // 
            this.applicationsGroupBox.Controls.Add(this.phpRestartButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbRestartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxRestartButton);
            this.applicationsGroupBox.Controls.Add(this.phpLogButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbLogButton);
            this.applicationsGroupBox.Controls.Add(this.nginxLogButton);
            this.applicationsGroupBox.Controls.Add(this.phpConfigButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbConfigButton);
            this.applicationsGroupBox.Controls.Add(this.nginxConfigButton);
            this.applicationsGroupBox.Controls.Add(this.label8);
            this.applicationsGroupBox.Controls.Add(this.label7);
            this.applicationsGroupBox.Controls.Add(this.phprunning);
            this.applicationsGroupBox.Controls.Add(this.mariadbrunning);
            this.applicationsGroupBox.Controls.Add(this.optionsLabel);
            this.applicationsGroupBox.Controls.Add(this.label4);
            this.applicationsGroupBox.Controls.Add(this.applicationLabel);
            this.applicationsGroupBox.Controls.Add(this.nginxrunning);
            this.applicationsGroupBox.Controls.Add(this.runningLabel);
            this.applicationsGroupBox.Controls.Add(this.mariadbStopButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStopButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStopButton);
            this.applicationsGroupBox.Location = new System.Drawing.Point(14, 35);
            this.applicationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.applicationsGroupBox.Size = new System.Drawing.Size(634, 229);
            this.applicationsGroupBox.TabIndex = 60;
            this.applicationsGroupBox.TabStop = false;
            this.applicationsGroupBox.Text = "Applications";
            // 
            // phpRestartButton
            // 
            this.phpRestartButton.Location = new System.Drawing.Point(322, 172);
            this.phpRestartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phpRestartButton.Name = "phpRestartButton";
            this.phpRestartButton.Size = new System.Drawing.Size(58, 36);
            this.phpRestartButton.TabIndex = 78;
            this.phpRestartButton.Text = "Restart";
            this.phpRestartButton.UseVisualStyleBackColor = true;
            this.phpRestartButton.Click += new System.EventHandler(this.PhpRestartButton_Click);
            // 
            // mariadbRestartButton
            // 
            this.mariadbRestartButton.Location = new System.Drawing.Point(322, 116);
            this.mariadbRestartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mariadbRestartButton.Name = "mariadbRestartButton";
            this.mariadbRestartButton.Size = new System.Drawing.Size(58, 36);
            this.mariadbRestartButton.TabIndex = 77;
            this.mariadbRestartButton.Text = "Restart";
            this.mariadbRestartButton.UseVisualStyleBackColor = true;
            this.mariadbRestartButton.Click += new System.EventHandler(this.MariadbRestartButton_Click);
            // 
            // nginxRestartButton
            // 
            this.nginxRestartButton.Location = new System.Drawing.Point(322, 59);
            this.nginxRestartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nginxRestartButton.Name = "nginxRestartButton";
            this.nginxRestartButton.Size = new System.Drawing.Size(58, 36);
            this.nginxRestartButton.TabIndex = 76;
            this.nginxRestartButton.Text = "Restart";
            this.nginxRestartButton.UseVisualStyleBackColor = true;
            this.nginxRestartButton.Click += new System.EventHandler(this.NginxRestartButton_Click);
            // 
            // phpLogButton
            // 
            this.phpLogButton.Location = new System.Drawing.Point(491, 172);
            this.phpLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phpLogButton.Name = "phpLogButton";
            this.phpLogButton.Size = new System.Drawing.Size(58, 36);
            this.phpLogButton.TabIndex = 75;
            this.phpLogButton.Text = "Logs";
            this.phpLogButton.UseVisualStyleBackColor = true;
            this.phpLogButton.Click += new System.EventHandler(this.PhpLogButton_Click);
            // 
            // mariadbLogButton
            // 
            this.mariadbLogButton.Location = new System.Drawing.Point(491, 116);
            this.mariadbLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mariadbLogButton.Name = "mariadbLogButton";
            this.mariadbLogButton.Size = new System.Drawing.Size(58, 36);
            this.mariadbLogButton.TabIndex = 74;
            this.mariadbLogButton.Text = "Logs";
            this.mariadbLogButton.UseVisualStyleBackColor = true;
            this.mariadbLogButton.Click += new System.EventHandler(this.MariadbLogButton_Click);
            // 
            // nginxLogButton
            // 
            this.nginxLogButton.Location = new System.Drawing.Point(491, 60);
            this.nginxLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nginxLogButton.Name = "nginxLogButton";
            this.nginxLogButton.Size = new System.Drawing.Size(58, 36);
            this.nginxLogButton.TabIndex = 73;
            this.nginxLogButton.Text = "Logs";
            this.nginxLogButton.UseVisualStyleBackColor = true;
            this.nginxLogButton.Click += new System.EventHandler(this.NginxLogButton_Click);
            // 
            // phpConfigButton
            // 
            this.phpConfigButton.Location = new System.Drawing.Point(387, 172);
            this.phpConfigButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phpConfigButton.Name = "phpConfigButton";
            this.phpConfigButton.Size = new System.Drawing.Size(97, 36);
            this.phpConfigButton.TabIndex = 72;
            this.phpConfigButton.Text = "Configuration";
            this.phpConfigButton.UseVisualStyleBackColor = true;
            this.phpConfigButton.Click += new System.EventHandler(this.PhpConfigButton_Click);
            // 
            // mariadbConfigButton
            // 
            this.mariadbConfigButton.Location = new System.Drawing.Point(387, 116);
            this.mariadbConfigButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mariadbConfigButton.Name = "mariadbConfigButton";
            this.mariadbConfigButton.Size = new System.Drawing.Size(97, 36);
            this.mariadbConfigButton.TabIndex = 71;
            this.mariadbConfigButton.Text = "Configuration";
            this.mariadbConfigButton.UseVisualStyleBackColor = true;
            this.mariadbConfigButton.Click += new System.EventHandler(this.MariadbConfigButton_Click);
            // 
            // nginxConfigButton
            // 
            this.nginxConfigButton.Location = new System.Drawing.Point(387, 59);
            this.nginxConfigButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nginxConfigButton.Name = "nginxConfigButton";
            this.nginxConfigButton.Size = new System.Drawing.Size(97, 36);
            this.nginxConfigButton.TabIndex = 70;
            this.nginxConfigButton.Text = "Configuration";
            this.nginxConfigButton.UseVisualStyleBackColor = true;
            this.nginxConfigButton.Click += new System.EventHandler(this.NginxConfigButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(92, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "PHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(92, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "MariaDB";
            // 
            // phprunning
            // 
            this.phprunning.AutoSize = true;
            this.phprunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phprunning.ForeColor = System.Drawing.Color.DarkRed;
            this.phprunning.Location = new System.Drawing.Point(26, 177);
            this.phprunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phprunning.Name = "phprunning";
            this.phprunning.Size = new System.Drawing.Size(21, 20);
            this.phprunning.TabIndex = 67;
            this.phprunning.Text = "X";
            // 
            // mariadbrunning
            // 
            this.mariadbrunning.AutoSize = true;
            this.mariadbrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.mariadbrunning.Location = new System.Drawing.Point(26, 119);
            this.mariadbrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mariadbrunning.Name = "mariadbrunning";
            this.mariadbrunning.Size = new System.Drawing.Size(21, 20);
            this.mariadbrunning.TabIndex = 66;
            this.mariadbrunning.Text = "X";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsLabel.Location = new System.Drawing.Point(191, 31);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(50, 13);
            this.optionsLabel.TabIndex = 65;
            this.optionsLabel.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(92, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nginx";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.applicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applicationLabel.Location = new System.Drawing.Point(92, 31);
            this.applicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(70, 13);
            this.applicationLabel.TabIndex = 62;
            this.applicationLabel.Text = "Application";
            // 
            // nginxrunning
            // 
            this.nginxrunning.AutoSize = true;
            this.nginxrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.nginxrunning.Location = new System.Drawing.Point(26, 61);
            this.nginxrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nginxrunning.Name = "nginxrunning";
            this.nginxrunning.Size = new System.Drawing.Size(21, 20);
            this.nginxrunning.TabIndex = 61;
            this.nginxrunning.Text = "X";
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.BackColor = System.Drawing.Color.Transparent;
            this.runningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.runningLabel.Location = new System.Drawing.Point(7, 31);
            this.runningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(54, 13);
            this.runningLabel.TabIndex = 60;
            this.runningLabel.Text = "Running";
            // 
            // mariadbStopButton
            // 
            this.mariadbStopButton.Location = new System.Drawing.Point(257, 117);
            this.mariadbStopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mariadbStopButton.Name = "mariadbStopButton";
            this.mariadbStopButton.Size = new System.Drawing.Size(58, 36);
            this.mariadbStopButton.TabIndex = 57;
            this.mariadbStopButton.Text = "Stop";
            this.mariadbStopButton.UseVisualStyleBackColor = true;
            this.mariadbStopButton.Click += new System.EventHandler(this.MariadbStopButton_Click);
            // 
            // mariadbStartButton
            // 
            this.mariadbStartButton.Location = new System.Drawing.Point(191, 117);
            this.mariadbStartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mariadbStartButton.Name = "mariadbStartButton";
            this.mariadbStartButton.Size = new System.Drawing.Size(58, 36);
            this.mariadbStartButton.TabIndex = 56;
            this.mariadbStartButton.Text = "Start";
            this.mariadbStartButton.UseVisualStyleBackColor = true;
            this.mariadbStartButton.Click += new System.EventHandler(this.MariadbStartButton_Click);
            // 
            // phpStartButton
            // 
            this.phpStartButton.Location = new System.Drawing.Point(191, 172);
            this.phpStartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phpStartButton.Name = "phpStartButton";
            this.phpStartButton.Size = new System.Drawing.Size(58, 36);
            this.phpStartButton.TabIndex = 55;
            this.phpStartButton.Text = "Start";
            this.phpStartButton.UseVisualStyleBackColor = true;
            this.phpStartButton.Click += new System.EventHandler(this.PhpStartButton_Click);
            // 
            // phpStopButton
            // 
            this.phpStopButton.Location = new System.Drawing.Point(257, 172);
            this.phpStopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phpStopButton.Name = "phpStopButton";
            this.phpStopButton.Size = new System.Drawing.Size(58, 36);
            this.phpStopButton.TabIndex = 54;
            this.phpStopButton.Text = "Stop";
            this.phpStopButton.UseVisualStyleBackColor = true;
            this.phpStopButton.Click += new System.EventHandler(this.PhpStopButton_Click);
            // 
            // nginxStartButton
            // 
            this.nginxStartButton.Location = new System.Drawing.Point(191, 59);
            this.nginxStartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nginxStartButton.Name = "nginxStartButton";
            this.nginxStartButton.Size = new System.Drawing.Size(58, 36);
            this.nginxStartButton.TabIndex = 53;
            this.nginxStartButton.Text = "Start";
            this.nginxStartButton.UseVisualStyleBackColor = true;
            this.nginxStartButton.Click += new System.EventHandler(this.NginxStartButton_Click);
            // 
            // nginxStopButton
            // 
            this.nginxStopButton.Location = new System.Drawing.Point(257, 59);
            this.nginxStopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nginxStopButton.Name = "nginxStopButton";
            this.nginxStopButton.Size = new System.Drawing.Size(58, 36);
            this.nginxStopButton.TabIndex = 52;
            this.nginxStopButton.Text = "Stop";
            this.nginxStopButton.UseVisualStyleBackColor = true;
            this.nginxStopButton.Click += new System.EventHandler(this.NginxStopButton_Click);
            // 
            // startAllButton
            // 
            this.startAllButton.Location = new System.Drawing.Point(667, 35);
            this.startAllButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startAllButton.Name = "startAllButton";
            this.startAllButton.Size = new System.Drawing.Size(74, 48);
            this.startAllButton.TabIndex = 62;
            this.startAllButton.Text = "Start all";
            this.startAllButton.UseVisualStyleBackColor = true;
            this.startAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // stopAllButton
            // 
            this.stopAllButton.Location = new System.Drawing.Point(667, 88);
            this.stopAllButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopAllButton.Name = "stopAllButton";
            this.stopAllButton.Size = new System.Drawing.Size(74, 48);
            this.stopAllButton.TabIndex = 63;
            this.stopAllButton.Text = "Stop all";
            this.stopAllButton.UseVisualStyleBackColor = true;
            this.stopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // openMariaDBShellButton
            // 
            this.openMariaDBShellButton.Location = new System.Drawing.Point(667, 143);
            this.openMariaDBShellButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openMariaDBShellButton.Name = "openMariaDBShellButton";
            this.openMariaDBShellButton.Size = new System.Drawing.Size(74, 65);
            this.openMariaDBShellButton.TabIndex = 64;
            this.openMariaDBShellButton.Text = "Open MariaDB Shell";
            this.openMariaDBShellButton.UseVisualStyleBackColor = true;
            this.openMariaDBShellButton.Click += new System.EventHandler(this.OpenMariaDBShellButton_Click);
            // 
            // AppsRunningTimer
            // 
            this.AppsRunningTimer.Enabled = true;
            this.AppsRunningTimer.Interval = 1000;
            this.AppsRunningTimer.Tick += new System.EventHandler(this.AppsRunningTimer_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 473);
            this.Controls.Add(this.wnmpDirButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.applicationsGroupBox);
            this.Controls.Add(this.startAllButton);
            this.Controls.Add(this.stopAllButton);
            this.Controls.Add(this.openMariaDBShellButton);
            this.Controls.Add(this.WnmpMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.WnmpMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Wnmp Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.WnmpMenuStrip.ResumeLayout(false);
            this.WnmpMenuStrip.PerformLayout();
            this.applicationsGroupBox.ResumeLayout(false);
            this.applicationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip WnmpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button wnmpDirButton;
        public System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.Button phpLogButton;
        private System.Windows.Forms.Button mariadbLogButton;
        private System.Windows.Forms.Button nginxLogButton;
        private System.Windows.Forms.Button phpConfigButton;
        private System.Windows.Forms.Button mariadbConfigButton;
        private System.Windows.Forms.Button nginxConfigButton;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.ToolStripMenuItem wnmpOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHTTPHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button nginxRestartButton;
        private System.Windows.Forms.Button mariadbStopButton;
        private System.Windows.Forms.Button mariadbStartButton;
        private System.Windows.Forms.Button phpStartButton;
        private System.Windows.Forms.Button phpStopButton;
        private System.Windows.Forms.Button nginxStartButton;
        private System.Windows.Forms.Button nginxStopButton;
        private System.Windows.Forms.Button phpRestartButton;
        private System.Windows.Forms.Button mariadbRestartButton;
        private System.Windows.Forms.Button startAllButton;
        private System.Windows.Forms.Button stopAllButton;
        private System.Windows.Forms.Button openMariaDBShellButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phprunning;
        private System.Windows.Forms.Label mariadbrunning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nginxrunning;
        private System.Windows.Forms.Timer AppsRunningTimer;
        private System.Windows.Forms.ToolStripMenuItem setupMariaDBToolStripMenuItem;
    }
}