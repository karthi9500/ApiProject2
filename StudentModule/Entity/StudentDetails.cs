using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentModule.Entity
{
    [Table("studentdetails")]
    public class StudentDetails


    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string dep { get; set; }

        public bool isActive { get; set; }
    }

}
