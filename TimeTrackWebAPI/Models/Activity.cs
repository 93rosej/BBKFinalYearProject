//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTrackWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int activityID { get; set; }
        public int userID { get; set; }
        public int processID { get; set; }
        public int processWindowTitleID { get; set; }
        public System.DateTime processStartTime { get; set; }
        public System.DateTime processEndTime { get; set; }
    
        public virtual Process Process { get; set; }
        public virtual ProcessWindow ProcessWindow { get; set; }
        public virtual User User { get; set; }
    }
}
