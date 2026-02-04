using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_Management_System.Models
{
    public class AttendanceModel
    {
        public int id { get; set; }
        public int studentID { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public DateTime in_time { get; set; }
    }
}