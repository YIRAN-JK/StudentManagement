using System;
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
            return Ok(_studentRepository.GetAllStudents());
        }

        [HttpGet("{studentId}")]
        public IActionResult GetStudentMessage(int studentId)
        {
            return Ok(_studentRepository.SearchStudent(studentId));
        }
        
    }
}