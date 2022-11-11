using StudentModel.Abstract;
using StudentModel.ViewModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModel.Services
{
     public class StudentService : IstudentService
    {
        private readonly IstudentRepo _Istudentrepo;
        public StudentService (IstudentRepo studentrepo)
        {
            _Istudentrepo = studentrepo;
        }

        public List<StudentViewModel> getAllStudent()
        {
            var data = _Istudentrepo.getAllStudent();
            return data;
        }

        public StudentViewModel GetEmployeeDetailsById(int id)
        {
            return _Istudentrepo.GetEmployeeDetailsById(id);
        }

        public bool insertStudentDetails(StudentViewModel details)
        {
            return _Istudentrepo.insertStudentDetails(details);
        }
    }
}
