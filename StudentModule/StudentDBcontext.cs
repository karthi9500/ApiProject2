using Microsoft.EntityFrameworkCore;
using StudentModule.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule
{
    public class StudentDBcontext : DbContext
    {
        public StudentDBcontext()
        {

        }
        public StudentDBcontext(DbContextOptions<StudentDBcontext> options) : base(options)
        {

        }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        public virtual DbSet<StudentDetails> StudentDetail { get; set; }

    }
}
