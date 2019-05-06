namespace TimeTrack
{
    partial class DemoApp
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabOverview = new MetroFramework.Controls.MetroTabPage();
            this.currentUser = new MetroFramework.Controls.MetroLabel();
            this.labelUser = new MetroFramework.Controls.MetroLabel();
            this.currentProcessTextBox = new MetroFramework.Controls.MetroLabel();
            this.currentTime = new MetroFramework.Controls.MetroLabel();
            this.startStop = new MetroFramework.Controls.MetroButton();
            this.labelCurrentTime = new MetroFramework.Controls.MetroLabel();
            this.labelCurrentProcess = new MetroFramework.Controls.MetroLabel();
            this.StartRecording = new MetroFramework.Controls.MetroButton();
            this.tabActivityLog = new MetroFramework.Controls.MetroTabPage();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.listViewActivities = new MetroFramework.Controls.MetroListView();
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDatabase = new MetroFramework.Controls.MetroTabPage();
            this.labelServer = new MetroFramework.Controls.MetroLabel();
            this.textBoxServer = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDatabase = new MetroFramework.Controls.MetroTextBox();
            this.labelDatabase = new MetroFramework.Controls.MetroLabel();
            this.buttonConnect = new MetroFramework.Controls.MetroButton();
            this.textBoxStatus = new MetroFramework.Controls.MetroTextBox();
            this.labelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonInsertSampleData = new MetroFramework.Controls.MetroButton();
            this.buttonClearDBData = new MetroFramework.Controls.MetroButton();
            this.buttonWindowsAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.buttonSQLAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.textBoxSQLPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelSQLPassword = new MetroFramework.Controls.MetroLabel();
            this.textBoxSQLUser = new MetroFramework.Controls.MetroTextBox();
            this.labelSQLUser = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tabActivityLog.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabOverview);
            this.metroTabControl1.Controls.Add(this.tabActivityLog);
            this.metroTabControl1.Controls.Add(this.tabDatabase);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(536, 522);
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.currentUser);
            this.tabOverview.Controls.Add(this.labelUser);
            this.tabOverview.Controls.Add(this.currentProcessTextBox);
            this.tabOverview.Controls.Add(this.currentTime);
            this.tabOverview.Controls.Add(this.startStop);
            this.tabOverview.Controls.Add(this.labelCurrentTime);
            this.tabOverview.Controls.Add(this.labelCurrentProcess);
            this.tabOverview.Controls.Add(this.StartRecording);
            this.tabOverview.HorizontalScrollbarBarColor = true;
            this.tabOverview.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOverview.HorizontalScrollbarSize = 10;
            this.tabOverview.Location = new System.Drawing.Point(4, 38);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(528, 480);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.VerticalScrollbarBarColor = true;
            this.tabOverview.VerticalScrollbarHighlightOnWheel = false;
            this.tabOverview.VerticalScrollbarSize = 10;
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Location = new System.Drawing.Point(189, 96);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(35, 19);
            this.currentUser.TabIndex = 17;
            this.currentUser.Text = "User";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(0, 96);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 19);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "User";
            // 
            // currentProcessTextBox
            // 
            this.currentProcessTextBox.AutoSize = true;
            this.currentProcessTextBox.BackColor = System.Drawing.Color.White;
            this.currentProcessTextBox.Location = new System.Drawing.Point(189, 175);
            this.currentProcessTextBox.Name = "currentProcessTextBox";
            this.currentProcessTextBox.Size = new System.Drawing.Size(53, 19);
            this.currentProcessTextBox.TabIndex = 15;
            this.currentProcessTextBox.Text = "Process";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(189, 136);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(38, 19);
            this.currentTime.TabIndex = 14;
            this.currentTime.Text = "Time";
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(0, 26);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(187, 23);
            this.startStop.TabIndex = 13;
            this.startStop.Text = "Start Recording";
            this.startStop.UseSelectable = true;
            this.startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.White;
            this.labelCurrentTime.Location = new System.Drawing.Point(0, 136);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(86, 19);
            this.labelCurrentTime.TabIndex = 12;
            this.labelCurrentTime.Text = "Current Time";
            // 
            // labelCurrentProcess
            // 
            this.labelCurrentProcess.AutoSize = true;
            this.labelCurrentProcess.BackColor = System.Drawing.Color.White;
            this.labelCurrentProcess.Location = new System.Drawing.Point(0, 175);
            this.labelCurrentProcess.Name = "labelCurrentProcess";
            this.labelCurrentProcess.Size = new System.Drawing.Size(153, 19);
            this.labelCurrentProcess.TabIndex = 11;
            this.labelCurrentProcess.Text = "Current Focused Process";
            // 
            // StartRecording
            // 
            this.StartRecording.Location = new System.Drawing.Point(0, 55);
            this.StartRecording.Name = "StartRecording";
            this.StartRecording.Size = new System.Drawing.Size(187, 23);
            this.StartRecording.TabIndex = 10;
            this.StartRecording.Text = "Record Activity to Database";
            this.StartRecording.UseSelectable = true;
            // 
            // tabActivityLog
            // 
            this.tabActivityLog.Controls.Add(this.refreshButton);
            this.tabActivityLog.Controls.Add(this.listViewActivities);
            this.tabActivityLog.HorizontalScrollbarBarColor = true;
            this.tabActivityLog.HorizontalScrollbarHighlightOnWheel = false;
            this.tabActivityLog.HorizontalScrollbarSize = 10;
            this.tabActivityLog.Location = new System.Drawing.Point(4, 38);
            this.tabActivityLog.Name = "tabActivityLog";
            this.tabActivityLog.Size = new System.Drawing.Size(528, 480);
            this.tabActivityLog.TabIndex = 1;
            this.tabActivityLog.Text = "Activity Log";
            this.tabActivityLog.VerticalScrollbarBarColor = true;
            this.tabActivityLog.VerticalScrollbarHighlightOnWheel = false;
            this.tabActivityLog.VerticalScrollbarSize = 10;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(-1, 14);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user,
            this.timeStarted,
            this.timeEnded,
            this.activityDuration});
            this.listViewActivities.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.Location = new System.Drawing.Point(-1, 53);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.OwnerDraw = true;
            this.listViewActivities.Size = new System.Drawing.Size(533, 431);
            this.listViewActivities.TabIndex = 2;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.UseSelectable = true;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // user
            // 
            this.user.Text = "User";
            this.user.Width = 185;
            // 
            // timeStarted
            // 
            this.timeStarted.Text = "Time Started";
            this.timeStarted.Width = 102;
            // 
            // timeEnded
            // 
            this.timeEnded.Text = "Time Ended";
            this.timeEnded.Width = 100;
            // 
            // activityDuration
            // 
            this.activityDuration.Text = "Activity Duration";
            this.activityDuration.Width = 130;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.textBoxSQLPassword);
            this.tabDatabase.Controls.Add(this.labelSQLPassword);
            this.tabDatabase.Controls.Add(this.textBoxSQLUser);
            this.tabDatabase.Controls.Add(this.labelSQLUser);
            this.tabDatabase.Controls.Add(this.buttonSQLAuthentication);
            this.tabDatabase.Controls.Add(this.buttonWindowsAuthentication);
            this.tabDatabase.Controls.Add(this.buttonClearDBData);
            this.tabDatabase.Controls.Add(this.buttonInsertSampleData);
            this.tabDatabase.Controls.Add(this.textBoxStatus);
            this.tabDatabase.Controls.Add(this.labelStatus);
            this.tabDatabase.Controls.Add(this.buttonConnect);
            this.tabDatabase.Controls.Add(this.textBoxDatabase);
            this.tabDatabase.Controls.Add(this.labelDatabase);
            this.tabDatabase.Controls.Add(this.textBoxServer);
            this.tabDatabase.Controls.Add(this.labelServer);
            this.tabDatabase.HorizontalScrollbarBarColor = true;
            this.tabDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDatabase.HorizontalScrollbarSize = 10;
            this.tabDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Size = new System.Drawing.Size(528, 480);
            this.tabDatabase.TabIndex = 2;
            this.tabDatabase.Text = "Database Connection";
            this.tabDatabase.VerticalScrollbarBarColor = true;
            this.tabDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabDatabase.VerticalScrollbarSize = 10;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(14, 16);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(47, 19);
            this.labelServer.TabIndex = 2;
            this.labelServer.Text = "Server";
            // 
            // textBoxServer
            // 
            // 
            // 
            // 
            this.textBoxServer.CustomButton.Image = null;
            this.textBoxServer.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxServer.CustomButton.Name = "";
            this.textBoxServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxServer.CustomButton.TabIndex = 1;
            this.textBoxServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxServer.CustomButton.UseSelectable = true;
            this.textBoxServer.CustomButton.Visible = false;
            this.textBoxServer.Lines = new string[] {
        "localhost"};
            this.textBoxServer.Location = new System.Drawing.Point(135, 16);
            this.textBoxServer.MaxLength = 32767;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.PasswordChar = '\0';
            this.textBoxServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxServer.SelectedText = "";
            this.textBoxServer.SelectionLength = 0;
            this.textBoxServer.SelectionStart = 0;
            this.textBoxServer.ShortcutsEnabled = true;
            this.textBoxServer.Size = new System.Drawing.Size(179, 23);
            this.textBoxServer.TabIndex = 3;
            this.textBoxServer.Text = "localhost";
            this.textBoxServer.UseSelectable = true;
            this.textBoxServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxDatabase
            // 
            // 
            // 
            // 
            this.textBoxDatabase.CustomButton.Image = null;
            this.textBoxDatabase.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxDatabase.CustomButton.Name = "";
            this.textBoxDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDatabase.CustomButton.TabIndex = 1;
            this.textBoxDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDatabase.CustomButton.UseSelectable = true;
            this.textBoxDatabase.CustomButton.Visible = false;
            this.textBoxDatabase.Lines = new string[] {
        "TimeTrack"};
            this.textBoxDatabase.Location = new System.Drawing.Point(135, 54);
            this.textBoxDatabase.MaxLength = 32767;
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.PasswordChar = '\0';
            this.textBoxDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDatabase.SelectedText = "";
            this.textBoxDatabase.SelectionLength = 0;
            this.textBoxDatabase.SelectionStart = 0;
            this.textBoxDatabase.ShortcutsEnabled = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(179, 23);
            this.textBoxDatabase.TabIndex = 5;
            this.textBoxDatabase.Text = "TimeTrack";
            this.textBoxDatabase.UseSelectable = true;
            this.textBoxDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(14, 54);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(103, 19);
            this.labelDatabase.TabIndex = 4;
            this.labelDatabase.Text = "Database Name";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(349, 16);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(162, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseSelectable = true;
            // 
            // textBoxStatus
            // 
            // 
            // 
            // 
            this.textBoxStatus.CustomButton.Image = null;
            this.textBoxStatus.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxStatus.CustomButton.Name = "";
            this.textBoxStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxStatus.CustomButton.TabIndex = 1;
            this.textBoxStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxStatus.CustomButton.UseSelectable = true;
            this.textBoxStatus.CustomButton.Visible = false;
            this.textBoxStatus.Lines = new string[] {
        "Disconnected"};
            this.textBoxStatus.Location = new System.Drawing.Point(135, 93);
            this.textBoxStatus.MaxLength = 32767;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.PasswordChar = '\0';
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxStatus.SelectedText = "";
            this.textBoxStatus.SelectionLength = 0;
            this.textBoxStatus.SelectionStart = 0;
            this.textBoxStatus.ShortcutsEnabled = true;
            this.textBoxStatus.Size = new System.Drawing.Size(179, 23);
            this.textBoxStatus.TabIndex = 8;
            this.textBoxStatus.Text = "Disconnected";
            this.textBoxStatus.UseSelectable = true;
            this.textBoxStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(14, 93);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 19);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(528, 480);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Reporting";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // buttonInsertSampleData
            // 
            this.buttonInsertSampleData.Location = new System.Drawing.Point(349, 54);
            this.buttonInsertSampleData.Name = "buttonInsertSampleData";
            this.buttonInsertSampleData.Size = new System.Drawing.Size(162, 23);
            this.buttonInsertSampleData.TabIndex = 9;
            this.buttonInsertSampleData.Text = "Insert Sample Database Data";
            this.buttonInsertSampleData.UseSelectable = true;
            // 
            // buttonClearDBData
            // 
            this.buttonClearDBData.Location = new System.Drawing.Point(349, 93);
            this.buttonClearDBData.Name = "buttonClearDBData";
            this.buttonClearDBData.Size = new System.Drawing.Size(162, 23);
            this.buttonClearDBData.TabIndex = 10;
            this.buttonClearDBData.Text = "Clear Database Data";
            this.buttonClearDBData.UseSelectable = true;
            this.buttonClearDBData.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // buttonWindowsAuthentication
            // 
            this.buttonWindowsAuthentication.AutoSize = true;
            this.buttonWindowsAuthentication.Checked = true;
            this.buttonWindowsAuthentication.Location = new System.Drawing.Point(14, 134);
            this.buttonWindowsAuthentication.Name = "buttonWindowsAuthentication";
            this.buttonWindowsAuthentication.Size = new System.Drawing.Size(154, 15);
            this.buttonWindowsAuthentication.TabIndex = 11;
            this.buttonWindowsAuthentication.TabStop = true;
            this.buttonWindowsAuthentication.Text = "Windows Authentication";
            this.buttonWindowsAuthentication.UseSelectable = true;
            this.buttonWindowsAuthentication.CheckedChanged += new System.EventHandler(this.buttonWindowsAuthentication_CheckedChanged);
            // 
            // buttonSQLAuthentication
            // 
            this.buttonSQLAuthentication.AutoSize = true;
            this.buttonSQLAuthentication.Location = new System.Drawing.Point(188, 134);
            this.buttonSQLAuthentication.Name = "buttonSQLAuthentication";
            this.buttonSQLAuthentication.Size = new System.Drawing.Size(126, 15);
            this.buttonSQLAuthentication.TabIndex = 12;
            this.buttonSQLAuthentication.Text = "SQL Authentication";
            this.buttonSQLAuthentication.UseSelectable = true;
            this.buttonSQLAuthentication.CheckedChanged += new System.EventHandler(this.buttonSQLAuthentication_CheckedChanged);
            // 
            // textBoxSQLPassword
            // 
            // 
            // 
            // 
            this.textBoxSQLPassword.CustomButton.Image = null;
            this.textBoxSQLPassword.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxSQLPassword.CustomButton.Name = "";
            this.textBoxSQLPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSQLPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSQLPassword.CustomButton.TabIndex = 1;
            this.textBoxSQLPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSQLPassword.CustomButton.UseSelectable = true;
            this.textBoxSQLPassword.CustomButton.Visible = false;
            this.textBoxSQLPassword.Lines = new string[0];
            this.textBoxSQLPassword.Location = new System.Drawing.Point(135, 218);
            this.textBoxSQLPassword.MaxLength = 32767;
            this.textBoxSQLPassword.Name = "textBoxSQLPassword";
            this.textBoxSQLPassword.PasswordChar = '*';
            this.textBoxSQLPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSQLPassword.SelectedText = "";
            this.textBoxSQLPassword.SelectionLength = 0;
            this.textBoxSQLPassword.SelectionStart = 0;
            this.textBoxSQLPassword.ShortcutsEnabled = true;
            this.textBoxSQLPassword.Size = new System.Drawing.Size(179, 23);
            this.textBoxSQLPassword.TabIndex = 16;
            this.textBoxSQLPassword.UseSelectable = true;
            this.textBoxSQLPassword.Visible = false;
            this.textBoxSQLPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSQLPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelSQLPassword
            // 
            this.labelSQLPassword.AutoSize = true;
            this.labelSQLPassword.Location = new System.Drawing.Point(14, 218);
            this.labelSQLPassword.Name = "labelSQLPassword";
            this.labelSQLPassword.Size = new System.Drawing.Size(91, 19);
            this.labelSQLPassword.TabIndex = 15;
            this.labelSQLPassword.Text = "SQL Password";
            this.labelSQLPassword.Visible = false;
            // 
            // textBoxSQLUser
            // 
            // 
            // 
            // 
            this.textBoxSQLUser.CustomButton.Image = null;
            this.textBoxSQLUser.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxSQLUser.CustomButton.Name = "";
            this.textBoxSQLUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSQLUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSQLUser.CustomButton.TabIndex = 1;
            this.textBoxSQLUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSQLUser.CustomButton.UseSelectable = true;
            this.textBoxSQLUser.CustomButton.Visible = false;
            this.textBoxSQLUser.Lines = new string[] {
        "sa"};
            this.textBoxSQLUser.Location = new System.Drawing.Point(135, 180);
            this.textBoxSQLUser.MaxLength = 32767;
            this.textBoxSQLUser.Name = "textBoxSQLUser";
            this.textBoxSQLUser.PasswordChar = '\0';
            this.textBoxSQLUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSQLUser.SelectedText = "";
            this.textBoxSQLUser.SelectionLength = 0;
            this.textBoxSQLUser.SelectionStart = 0;
            this.textBoxSQLUser.ShortcutsEnabled = true;
            this.textBoxSQLUser.Size = new System.Drawing.Size(179, 23);
            this.textBoxSQLUser.TabIndex = 14;
            this.textBoxSQLUser.Text = "sa";
            this.textBoxSQLUser.UseSelectable = true;
            this.textBoxSQLUser.Visible = false;
            this.textBoxSQLUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSQLUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelSQLUser
            // 
            this.labelSQLUser.AutoSize = true;
            this.labelSQLUser.Location = new System.Drawing.Point(14, 180);
            this.labelSQLUser.Name = "labelSQLUser";
            this.labelSQLUser.Size = new System.Drawing.Size(103, 19);
            this.labelSQLUser.TabIndex = 13;
            this.labelSQLUser.Text = "SQL User Name";
            this.labelSQLUser.Visible = false;
            // 
            // DemoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 602);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "DemoApp";
            this.Text = "Activity Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.tabActivityLog.ResumeLayout(false);
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabOverview;
        private MetroFramework.Controls.MetroLabel currentUser;
        private MetroFramework.Controls.MetroLabel labelUser;
        private MetroFramework.Controls.MetroLabel currentProcessTextBox;
        private MetroFramework.Controls.MetroLabel currentTime;
        private MetroFramework.Controls.MetroButton startStop;
        private MetroFramework.Controls.MetroLabel labelCurrentTime;
        private MetroFramework.Controls.MetroLabel labelCurrentProcess;
        private MetroFramework.Controls.MetroButton StartRecording;
        private MetroFramework.Controls.MetroTabPage tabActivityLog;
        private MetroFramework.Controls.MetroTabPage tabDatabase;
        private MetroFramework.Controls.MetroListView listViewActivities;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader timeStarted;
        private System.Windows.Forms.ColumnHeader timeEnded;
        private System.Windows.Forms.ColumnHeader activityDuration;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroTextBox textBoxStatus;
        private MetroFramework.Controls.MetroLabel labelStatus;
        private MetroFramework.Controls.MetroButton buttonConnect;
        private MetroFramework.Controls.MetroTextBox textBoxDatabase;
        private MetroFramework.Controls.MetroLabel labelDatabase;
        private MetroFramework.Controls.MetroTextBox textBoxServer;
        private MetroFramework.Controls.MetroLabel labelServer;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroButton buttonClearDBData;
        private MetroFramework.Controls.MetroButton buttonInsertSampleData;
        private MetroFramework.Controls.MetroRadioButton buttonSQLAuthentication;
        private MetroFramework.Controls.MetroRadioButton buttonWindowsAuthentication;
        private MetroFramework.Controls.MetroTextBox textBoxSQLPassword;
        private MetroFramework.Controls.MetroLabel labelSQLPassword;
        private MetroFramework.Controls.MetroTextBox textBoxSQLUser;
        private MetroFramework.Controls.MetroLabel labelSQLUser;
    }
}

