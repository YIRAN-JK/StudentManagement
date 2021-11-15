using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.DataBase;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Guid AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student SearchStudent(Guid id)
        {
            return _context.Students.FirstOrDefault(n => n.Id == id);
        }

        public Student DeleteStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
        }
    }
}