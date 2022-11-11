using StudentModel.Abstract;
using StudentModel.ViewModule;
using StudentModule;
using StudentModule.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentModel.Repository
{
    public class StudentRepo : IstudentRepo
    {
        private readonly StudentDBcontext _dbcontext;
        public StudentRepo(StudentDBcontext dbcontex)
        {
            _dbcontext = dbcontex;
        }
        public StudentViewModel GetEmployeeDetailsById(int id)
        {
            var studentdata = _dbcontext.StudentDetails.Where(k => k.id == id).Select(k => new StudentViewModel { id = k.id, address = k.address, age = k.age, dep = k.dep, name = k.name }).FirstOrDefault();
            return studentdata;
        }

        public List<StudentViewModel> getAllStudent()
        {
            var studentdata = _dbcontext.StudentDetail.Select(s => new StudentViewModel { id = s.id, address = s.address, age = s.age, dep = s.dep, name = s.name}).ToList();
            return studentdata;
        }

        public bool insertStudentDetails(StudentViewModel details)
        {
            StudentDetails sd = new StudentDetails();

            sd.name = details.name;
            sd.age = details.age;
            sd.dep = details.dep;
            sd.address = details.address;
            sd.isActive = true;

            _dbcontext.StudentDetail.Update(sd);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}

