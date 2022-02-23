using System;
using System.Collections.Generic;
using System.Text;

namespace Code_First_Student_dB
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public string StudentName { get; internal set; }
    }
}
