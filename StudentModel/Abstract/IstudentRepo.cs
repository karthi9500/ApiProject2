using StudentModel.ViewModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModel.Abstract
{
    public interface IstudentRepo
    {
        StudentViewModel GetEmployeeDetailsById(int id);

        List<StudentViewModel> getAllStudent();


        bool insertStudentDetails(StudentViewModel details);


    }
}
