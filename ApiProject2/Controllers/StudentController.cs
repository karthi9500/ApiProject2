using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentModel.Abstract;
using StudentModel.ViewModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IstudentService _studentService;

        public StudentController(IstudentService studentser)
        {
            _studentService = studentser;
        }
        [HttpGet]
        public StudentViewModel GetEmployeeDetailsById(int id = 1)
        {
            var data = _studentService.GetEmployeeDetailsById(id);
            return data;
        }
        [HttpGet]
        public List<StudentViewModel> getAllStudent()
        {
            var data = _studentService.getAllStudent();
            return data;
        }




        [HttpPost]
        public bool insertStudentDetails([FromBody] StudentViewModel details)
        {
            var data = _studentService.insertStudentDetails(details);
            return data;
        }


    }
}
