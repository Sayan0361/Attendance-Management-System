using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_Management_System.Models
{
    public class AnalyticsViewModel
    {
        public int Id { get; set; }
        public int LateDays { get; set; }
        public int PresentDays { get; set; }
        public int AbsentDays { get; set; }
        public int TotalDays { get; set; }
        public string Name { get; set; }
        public string _class {  get; set; }
        public int Roll_No { get; set; }
        public string Section { get; set; }
        public DateTime Registration_Date {  get; set; }
    }
}