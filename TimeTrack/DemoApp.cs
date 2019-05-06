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
        public static Boolean startedRecording = false;
        public static String currentProcess;

        public DemoApp()
        {
            InitializeComponent();
        }

        public delegate void delUpdateCurrentProcessTextBox (string varText);

        ThreadStart threadStart;
        Thread currentProcessUpdateThread;

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabOverview;
            currentUser.Text = Environment.UserName;
            currentTime.Text = DateTime.Now.ToLongTimeString();      
        }

        private void UpdateCurrentProcessTextBoxThread()
        {
            delUpdateCurrentProcessTextBox DelUpdateCurrentProcessTextBox = new delUpdateCurrentProcessTextBox(UpdateCurrentProcessTextBox);
            this.currentProcessTextBox.BeginInvoke(DelUpdateCurrentProcessTextBox, currentProcessUpdateThread.Name);
        }

        public void UpdateCurrentProcessTextBox(string input)
        {
            this.currentProcessTextBox.Text = input;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ensure timer is continually updated
            currentTime.Text = DateTime.Now.ToLongTimeString();
            // Set currently focused process - have to use thread and pass value as a delegate to allow text box to be updated

            FetchProcess();
        }

        private void FetchProcess()
        {
            currentProcess = GetProcessRunning.GetActiveProcess();
            threadStart = new ThreadStart(UpdateCurrentProcessTextBoxThread);
            currentProcessUpdateThread = new Thread(threadStart)
            {
                Name = currentProcess.ToString()
            };
            currentProcessUpdateThread.Start();
        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (!startedRecording)
            {
                startedRecording = true;
                Activity activity = new Activity();
                startStop.Text = "Stop Recording";
            }
            else
            {
                startedRecording = false;
                startStop.Text = "Start Recording";
            }
        }

        private List<Activity> GetActivityList()
        {
            var list = new List<Activity>();
            list.Add(new Activity() { userName = "Test", startTimeString = DateTime.Now.ToLongTimeString(), endTimeString = DateTime.Now.ToLongTimeString(), duration = 0 });
            return list;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var activities = GetActivityList();
            foreach (var activity in activities)
            {
                var row = new string[] { activity.userName, activity.startTimeString, activity.endTimeString, activity.duration.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = activity; // casting to Activity to get value

                // add any activities found to list control
                listViewActivities.Items.Add(lvi);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clear Database Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void buttonSQLAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLUser.Visible = true;
            labelSQLPassword.Visible = true;
            textBoxSQLUser.Visible = true;
            textBoxSQLPassword.Visible = true;
        }

        private void buttonWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLUser.Visible = false;
            labelSQLPassword.Visible = false;
            textBoxSQLUser.Visible = false;
            textBoxSQLPassword.Visible = false;
        }
    }


}
