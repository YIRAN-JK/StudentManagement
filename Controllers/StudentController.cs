using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Repository;
using WebApplication.Service;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("{studentId}")]
        public IActionResult GetStudentMessage(int studentId)
        {
            return Ok(_studentRepository.SearchStudent(studentId));
        }
        
    }
}