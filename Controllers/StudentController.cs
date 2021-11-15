using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Repository;
using WebApplication.Service;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var allStudentsList = _studentRepository.GetAllStudents();
            if (allStudentsList == null || !allStudentsList.Any())
            {
                return NotFound("啊哦，没有找到学生列表...");
            }
            return Ok(allStudentsList);
        }

        [HttpGet("{studentId}")]
        public IActionResult GetStudentMessage(Guid studentId)
        {
            var studentWithId = _studentRepository.SearchStudent(studentId);
            if (studentWithId == null)
            {
                return NotFound($"id为{studentId}的学生不存在哦！");
            }
            return Ok(studentWithId);
        }
        
    }
}