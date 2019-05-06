using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrack
{
    public class Activity
    {

        public int activityID { get; set; }
        public string userName { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int activityDuration { get; set; }

        public Activity()
        {
            this.userName = userName;
            this.startTime = startTime;
            this.activityDuration = activityDuration;
        }

    }
}
