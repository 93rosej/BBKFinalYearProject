using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TimeTrack
{
    public partial class DemoApp : MetroFramework.Forms.MetroForm
    {
        public static bool startedRecording = false;
        private static string currentProcess;
        private static string currentWindow;
        private static string lastWindowRecorded = "";
        private static string databaseServer, databaseName, databaseConnectionAuthentication, databaseSQLUsername, databaseSQLPassword;
        private static int duration = 0;

        public List<Activity> activityList;

        public DemoApp()
        {
            // Loads form
            InitializeComponent();
        }

        // Delegate for updating the current process text box in the form with the current process name

        public delegate void delUpdateCurrentProcessTextBox(string varText);

        ThreadStart threadStartProcess;
        Thread currentProcessUpdateThread;

        private static List<Activity> activities;

        // On loading form

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabOverview;
            currentUser.Text = GetCurrentUserName();
            currentUserDisplay.Text = GetCurrentDisplayName();
            currentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private string GetCurrentUserName()
        {
            return Environment.UserName;
        }

        private string GetCurrentDisplayName()
        {
            return System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
        }

        private void UpdateCurrentProcessTextBoxThread()
        {
            delUpdateCurrentProcessTextBox DelUpdateCurrentProcessTextBox = new delUpdateCurrentProcessTextBox(UpdateCurrentProcessTextBox);
            this.currentProcessTextBox.BeginInvoke(DelUpdateCurrentProcessTextBox, currentProcessUpdateThread.Name);
        }

        private void UpdateCurrentProcessTextBox(string input)
        {
            this.currentProcessTextBox.Text = input;
        }

        private void UpdateCurrentWindowTextBox(string input)
        {
            this.currentWindowTextBox.Text = input;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ensure timer is continually updated
            currentTime.Text = DateTime.Now.ToLongTimeString();
            FetchProcess();
            currentWindowTextBox.Text = ProcessState.GetActiveWindowTitle();

            //if (currentWindow != lastWindowRecorded)
            //{
            //    lastWindowRecorded = currentWindow;
            //    activityList.Add(new Activity() { userName = GetCurrentUserName(), startTime = DateTime.Now, activityDuration = duration });
            //    duration = 0;
            //    System.Diagnostics.Debug.WriteLine("Hit this if statement");
            //}

        }

        private string FetchProcess()
        {

            currentWindow = ProcessState.GetActiveWindowTitle();
            // Set currently focused process - have to use thread and pass value as a delegate to allow text box to be updated
            currentProcess = ProcessState.GetActiveProcess().ToString();
            threadStartProcess = new ThreadStart(UpdateCurrentProcessTextBoxThread);
            currentProcessUpdateThread = new Thread(threadStartProcess)
            {
                Name = currentProcess
            };
            currentProcessUpdateThread.Start();
            return currentWindow; //returns window title
        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (!startedRecording)
            {
                startedRecording = true;
                startStop.Text = "Stop Recording";
            }
            else
            {
                startedRecording = false;
                startStop.Text = "Start Recording";
            }
        }



        //private List<Activity> GetActivityList()
        //{
        //    list.Add(new Activity() { userName = GetCurrentUserName() });
        //}


        private void refreshButton_Click(object sender, EventArgs e)
        {
            // activities = GetActivityList();

            //foreach (var activity in activities)
            //{
            //    var row = new string[] { activity.userName, activity.startTimeString, activity.endTimeString, activity.duration.ToString() };
            //    var lvi = new ListViewItem(row);
            //    lvi.Tag = activity; // casting to Activity to get value

            //    // add any activities found to list control
                
            //}

            // listViewActivities.Items.Add(String.Format(GetCurrentUserName()));
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!Database.SQLConnected)
            {
                databaseServer = textBoxServer.Text;
                databaseName = textBoxDatabase.Text;
                if (buttonSQLAuthentication.Checked)
                {
                    databaseConnectionAuthentication = "SQL";
                }
                else if (buttonWindowsAuthentication.Checked)
                {
                    databaseConnectionAuthentication = "Windows";
                }
                databaseSQLUsername = textBoxSQLUser.Text;
                databaseSQLPassword = textBoxSQLPassword.Text;
                Database.ConnectToSQL(databaseServer, databaseName, databaseConnectionAuthentication, databaseSQLUsername, databaseSQLPassword);
            }

            if (Database.SQLConnected)
            {
                buttonConnectToDB.Enabled = true;
                buttonBuildDatabase.Enabled = true;
                buttonConnectToSQL.Text = "Disconnect";
            }
            else
            {
                buttonConnectToDB.Enabled = false;
                buttonBuildDatabase.Enabled = false;
                buttonConnectToSQL.Text = "Connect to SQL";
            }
        }

        private void buttonBuildDatabase_Click(object sender, EventArgs e)
        {
            if (Database.SQLConnected)
            {
                Database.BuildDatabase();
            }
            else
            {
                return;
            } 
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLaunchBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:8000");
        }

        private void buttonConnectToDB_Click(object sender, EventArgs e)
        {

        }

        private void tabDatabase_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clear Database Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void buttonSQLAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            // Make SQL Authentication text fields and labels visible on selecting SQL Authentication
            labelSQLUser.Visible = true;
            labelSQLPassword.Visible = true;
            textBoxSQLUser.Visible = true;
            textBoxSQLPassword.Visible = true;
        }

        private void buttonWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            // Make SQL Authentication text fields and labels invisible on selecting Windows Authentication
            labelSQLUser.Visible = false;
            labelSQLPassword.Visible = false;
            textBoxSQLUser.Visible = false;
            textBoxSQLPassword.Visible = false;
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
