using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrack
{
    class Activity
    {

        public static int activityID = 0;
        public string userName { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string startTimeString { get; set; }
        public string endTimeString { get; set; }
        public int duration { get; set; }

        public Activity()
        {
            activityID++;
            this.userName = Environment.UserName;
            this.startTime = DateTime.Now;
            this.startTimeString = startTime.ToString();
        }

        public void ActivityEnd()
        {
            this.endTime = DateTime.Now;
            this.endTimeString = endTime.ToString();
            TimeSpan duration = this.endTime.Subtract(this.startTime);
        }

    }
}
