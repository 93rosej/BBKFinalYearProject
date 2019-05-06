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
            this.currentUserDisplay = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.currentWindowTextBox = new MetroFramework.Controls.MetroLabel();
            this.labelCurrentWindow = new MetroFramework.Controls.MetroLabel();
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
            this.process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processWindow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDatabase = new MetroFramework.Controls.MetroTabPage();
            this.buttonBuildDatabase = new MetroFramework.Controls.MetroButton();
            this.buttonConnectToDB = new MetroFramework.Controls.MetroButton();
            this.textBoxSQLPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelSQLPassword = new MetroFramework.Controls.MetroLabel();
            this.textBoxSQLUser = new MetroFramework.Controls.MetroTextBox();
            this.labelSQLUser = new MetroFramework.Controls.MetroLabel();
            this.buttonSQLAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.buttonWindowsAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.buttonClearDBData = new MetroFramework.Controls.MetroButton();
            this.buttonInsertSampleData = new MetroFramework.Controls.MetroButton();
            this.textBoxStatus = new MetroFramework.Controls.MetroTextBox();
            this.labelStatus = new MetroFramework.Controls.MetroLabel();
            this.buttonConnectToSQL = new MetroFramework.Controls.MetroButton();
            this.textBoxDatabase = new MetroFramework.Controls.MetroTextBox();
            this.labelDatabase = new MetroFramework.Controls.MetroLabel();
            this.textBoxServer = new MetroFramework.Controls.MetroTextBox();
            this.labelServer = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.buttonLaunchBrowser = new MetroFramework.Controls.MetroButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tabActivityLog.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
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
            this.metroTabControl1.Size = new System.Drawing.Size(890, 574);
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.currentUserDisplay);
            this.tabOverview.Controls.Add(this.metroLabel2);
            this.tabOverview.Controls.Add(this.currentWindowTextBox);
            this.tabOverview.Controls.Add(this.labelCurrentWindow);
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
            this.tabOverview.Size = new System.Drawing.Size(882, 532);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.VerticalScrollbarBarColor = true;
            this.tabOverview.VerticalScrollbarHighlightOnWheel = false;
            this.tabOverview.VerticalScrollbarSize = 10;
            // 
            // currentUserDisplay
            // 
            this.currentUserDisplay.AutoSize = true;
            this.currentUserDisplay.Location = new System.Drawing.Point(192, 149);
            this.currentUserDisplay.Name = "currentUserDisplay";
            this.currentUserDisplay.Size = new System.Drawing.Size(0, 0);
            this.currentUserDisplay.TabIndex = 21;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(3, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "User Display Name";
            // 
            // currentWindowTextBox
            // 
            this.currentWindowTextBox.AutoSize = true;
            this.currentWindowTextBox.BackColor = System.Drawing.Color.White;
            this.currentWindowTextBox.Location = new System.Drawing.Point(192, 276);
            this.currentWindowTextBox.Name = "currentWindowTextBox";
            this.currentWindowTextBox.Size = new System.Drawing.Size(85, 19);
            this.currentWindowTextBox.TabIndex = 19;
            this.currentWindowTextBox.Text = "Window Title";
            this.currentWindowTextBox.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // labelCurrentWindow
            // 
            this.labelCurrentWindow.AutoSize = true;
            this.labelCurrentWindow.BackColor = System.Drawing.Color.White;
            this.labelCurrentWindow.Location = new System.Drawing.Point(3, 276);
            this.labelCurrentWindow.Name = "labelCurrentWindow";
            this.labelCurrentWindow.Size = new System.Drawing.Size(137, 19);
            this.labelCurrentWindow.TabIndex = 18;
            this.labelCurrentWindow.Text = "Focused Window Title";
            this.labelCurrentWindow.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Location = new System.Drawing.Point(192, 109);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(0, 0);
            this.currentUser.TabIndex = 17;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(3, 109);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(75, 19);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "User Name";
            // 
            // currentProcessTextBox
            // 
            this.currentProcessTextBox.AutoSize = true;
            this.currentProcessTextBox.BackColor = System.Drawing.Color.White;
            this.currentProcessTextBox.Location = new System.Drawing.Point(192, 232);
            this.currentProcessTextBox.Name = "currentProcessTextBox";
            this.currentProcessTextBox.Size = new System.Drawing.Size(53, 19);
            this.currentProcessTextBox.TabIndex = 15;
            this.currentProcessTextBox.Text = "Process";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(192, 191);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(38, 19);
            this.currentTime.TabIndex = 14;
            this.currentTime.Text = "Time";
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(3, 23);
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
            this.labelCurrentTime.Location = new System.Drawing.Point(3, 191);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(86, 19);
            this.labelCurrentTime.TabIndex = 12;
            this.labelCurrentTime.Text = "Current Time";
            // 
            // labelCurrentProcess
            // 
            this.labelCurrentProcess.AutoSize = true;
            this.labelCurrentProcess.BackColor = System.Drawing.Color.White;
            this.labelCurrentProcess.Location = new System.Drawing.Point(3, 232);
            this.labelCurrentProcess.Name = "labelCurrentProcess";
            this.labelCurrentProcess.Size = new System.Drawing.Size(153, 19);
            this.labelCurrentProcess.TabIndex = 11;
            this.labelCurrentProcess.Text = "Current Focused Process";
            // 
            // StartRecording
            // 
            this.StartRecording.Location = new System.Drawing.Point(3, 52);
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
            this.tabActivityLog.Size = new System.Drawing.Size(882, 532);
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
            this.process,
            this.processWindow,
            this.timeStarted,
            this.timeEnded,
            this.activityDuration});
            this.listViewActivities.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.GridLines = true;
            this.listViewActivities.Location = new System.Drawing.Point(-1, 53);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.OwnerDraw = true;
            this.listViewActivities.Size = new System.Drawing.Size(880, 466);
            this.listViewActivities.TabIndex = 2;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.UseSelectable = true;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // user
            // 
            this.user.Text = "User";
            this.user.Width = 189;
            // 
            // process
            // 
            this.process.Text = "Process Name";
            this.process.Width = 172;
            // 
            // processWindow
            // 
            this.processWindow.Text = "Window Title";
            this.processWindow.Width = 176;
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
            this.activityDuration.Width = 143;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.buttonBuildDatabase);
            this.tabDatabase.Controls.Add(this.buttonConnectToDB);
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
            this.tabDatabase.Controls.Add(this.buttonConnectToSQL);
            this.tabDatabase.Controls.Add(this.textBoxDatabase);
            this.tabDatabase.Controls.Add(this.labelDatabase);
            this.tabDatabase.Controls.Add(this.textBoxServer);
            this.tabDatabase.Controls.Add(this.labelServer);
            this.tabDatabase.HorizontalScrollbarBarColor = true;
            this.tabDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDatabase.HorizontalScrollbarSize = 10;
            this.tabDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Size = new System.Drawing.Size(882, 532);
            this.tabDatabase.TabIndex = 2;
            this.tabDatabase.Text = "Database Connection";
            this.tabDatabase.VerticalScrollbarBarColor = true;
            this.tabDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabDatabase.VerticalScrollbarSize = 10;
            this.tabDatabase.Click += new System.EventHandler(this.tabDatabase_Click);
            // 
            // buttonBuildDatabase
            // 
            this.buttonBuildDatabase.Enabled = false;
            this.buttonBuildDatabase.Location = new System.Drawing.Point(498, 54);
            this.buttonBuildDatabase.Name = "buttonBuildDatabase";
            this.buttonBuildDatabase.Size = new System.Drawing.Size(162, 23);
            this.buttonBuildDatabase.TabIndex = 18;
            this.buttonBuildDatabase.Text = "Build Database";
            this.buttonBuildDatabase.UseSelectable = true;
            this.buttonBuildDatabase.Click += new System.EventHandler(this.buttonBuildDatabase_Click);
            // 
            // buttonConnectToDB
            // 
            this.buttonConnectToDB.Enabled = false;
            this.buttonConnectToDB.Location = new System.Drawing.Point(498, 93);
            this.buttonConnectToDB.Name = "buttonConnectToDB";
            this.buttonConnectToDB.Size = new System.Drawing.Size(162, 23);
            this.buttonConnectToDB.TabIndex = 17;
            this.buttonConnectToDB.Text = "Insert Activities";
            this.buttonConnectToDB.UseSelectable = true;
            this.buttonConnectToDB.Click += new System.EventHandler(this.buttonConnectToDB_Click);
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
            this.textBoxSQLPassword.Location = new System.Drawing.Point(135, 225);
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
            this.labelSQLPassword.Location = new System.Drawing.Point(14, 225);
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
            this.textBoxSQLUser.Location = new System.Drawing.Point(135, 187);
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
            this.labelSQLUser.Location = new System.Drawing.Point(14, 187);
            this.labelSQLUser.Name = "labelSQLUser";
            this.labelSQLUser.Size = new System.Drawing.Size(103, 19);
            this.labelSQLUser.TabIndex = 13;
            this.labelSQLUser.Text = "SQL User Name";
            this.labelSQLUser.Visible = false;
            // 
            // buttonSQLAuthentication
            // 
            this.buttonSQLAuthentication.AutoSize = true;
            this.buttonSQLAuthentication.Location = new System.Drawing.Point(188, 141);
            this.buttonSQLAuthentication.Name = "buttonSQLAuthentication";
            this.buttonSQLAuthentication.Size = new System.Drawing.Size(126, 15);
            this.buttonSQLAuthentication.TabIndex = 12;
            this.buttonSQLAuthentication.Text = "SQL Authentication";
            this.buttonSQLAuthentication.UseSelectable = true;
            this.buttonSQLAuthentication.CheckedChanged += new System.EventHandler(this.buttonSQLAuthentication_CheckedChanged);
            // 
            // buttonWindowsAuthentication
            // 
            this.buttonWindowsAuthentication.AutoSize = true;
            this.buttonWindowsAuthentication.Checked = true;
            this.buttonWindowsAuthentication.Location = new System.Drawing.Point(14, 141);
            this.buttonWindowsAuthentication.Name = "buttonWindowsAuthentication";
            this.buttonWindowsAuthentication.Size = new System.Drawing.Size(154, 15);
            this.buttonWindowsAuthentication.TabIndex = 11;
            this.buttonWindowsAuthentication.TabStop = true;
            this.buttonWindowsAuthentication.Text = "Windows Authentication";
            this.buttonWindowsAuthentication.UseSelectable = true;
            this.buttonWindowsAuthentication.CheckedChanged += new System.EventHandler(this.buttonWindowsAuthentication_CheckedChanged);
            // 
            // buttonClearDBData
            // 
            this.buttonClearDBData.Enabled = false;
            this.buttonClearDBData.Location = new System.Drawing.Point(498, 172);
            this.buttonClearDBData.Name = "buttonClearDBData";
            this.buttonClearDBData.Size = new System.Drawing.Size(162, 23);
            this.buttonClearDBData.TabIndex = 10;
            this.buttonClearDBData.Text = "Clear Database Data";
            this.buttonClearDBData.UseSelectable = true;
            this.buttonClearDBData.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // buttonInsertSampleData
            // 
            this.buttonInsertSampleData.Enabled = false;
            this.buttonInsertSampleData.Location = new System.Drawing.Point(498, 133);
            this.buttonInsertSampleData.Name = "buttonInsertSampleData";
            this.buttonInsertSampleData.Size = new System.Drawing.Size(162, 23);
            this.buttonInsertSampleData.TabIndex = 9;
            this.buttonInsertSampleData.Text = "Insert Sample Database Data";
            this.buttonInsertSampleData.UseSelectable = true;
            // 
            // textBoxStatus
            // 
            // 
            // 
            // 
            this.textBoxStatus.CustomButton.Image = null;
            this.textBoxStatus.CustomButton.Location = new System.Drawing.Point(241, 1);
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
            this.textBoxStatus.Size = new System.Drawing.Size(263, 23);
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
            // buttonConnectToSQL
            // 
            this.buttonConnectToSQL.Location = new System.Drawing.Point(498, 16);
            this.buttonConnectToSQL.Name = "buttonConnectToSQL";
            this.buttonConnectToSQL.Size = new System.Drawing.Size(162, 23);
            this.buttonConnectToSQL.TabIndex = 6;
            this.buttonConnectToSQL.Text = "Connect to SQL";
            this.buttonConnectToSQL.UseSelectable = true;
            this.buttonConnectToSQL.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxDatabase
            // 
            // 
            // 
            // 
            this.textBoxDatabase.CustomButton.Image = null;
            this.textBoxDatabase.CustomButton.Location = new System.Drawing.Point(241, 1);
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
            this.textBoxDatabase.Size = new System.Drawing.Size(263, 23);
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
            // textBoxServer
            // 
            // 
            // 
            // 
            this.textBoxServer.CustomButton.Image = null;
            this.textBoxServer.CustomButton.Location = new System.Drawing.Point(241, 1);
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
            this.textBoxServer.Size = new System.Drawing.Size(263, 23);
            this.textBoxServer.TabIndex = 3;
            this.textBoxServer.Text = "localhost";
            this.textBoxServer.UseSelectable = true;
            this.textBoxServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.buttonLaunchBrowser);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(882, 532);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Reporting";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 26);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(348, 26);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Start Web Service";
            this.metroButton1.UseSelectable = true;
            // 
            // buttonLaunchBrowser
            // 
            this.buttonLaunchBrowser.Location = new System.Drawing.Point(0, 77);
            this.buttonLaunchBrowser.Name = "buttonLaunchBrowser";
            this.buttonLaunchBrowser.Size = new System.Drawing.Size(348, 26);
            this.buttonLaunchBrowser.TabIndex = 2;
            this.buttonLaunchBrowser.Text = "Launch Browser for Reporting";
            this.buttonLaunchBrowser.UseSelectable = true;
            this.buttonLaunchBrowser.Click += new System.EventHandler(this.buttonLaunchBrowser_Click);
            // 
            // DemoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
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
            this.metroTabPage1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroButton buttonConnectToSQL;
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
        private System.Windows.Forms.ColumnHeader process;
        private MetroFramework.Controls.MetroButton buttonConnectToDB;
        private MetroFramework.Controls.MetroButton buttonBuildDatabase;
        private MetroFramework.Controls.MetroLabel currentWindowTextBox;
        private MetroFramework.Controls.MetroLabel labelCurrentWindow;
        private System.Windows.Forms.ColumnHeader processWindow;
        private MetroFramework.Controls.MetroLabel currentUserDisplay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton buttonLaunchBrowser;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

