using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_Management_System.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int roll_no { get; set; }
        public string section { get; set; }
        public string _class { get; set; }
    }
}