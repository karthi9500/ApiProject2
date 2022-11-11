using StudentModel.ViewModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModel.Abstract
{
     public interface IstudentService
    {
        StudentViewModel GetEmployeeDetailsById(int id);

        List<StudentViewModel> getAllStudent();

        bool insertStudentDetails( StudentViewModel details);
        
    }
}
