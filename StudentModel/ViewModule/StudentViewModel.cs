using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModel.ViewModule
{
     public class StudentViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string dep { get; set; }

        public bool isActive { get; set; }
    }
}
