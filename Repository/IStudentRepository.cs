using System;
using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public interface IStudentRepository
    {
        Guid AddStudent(Student student);

        Student SearchStudent(Guid id);
        
        Student DeleteStudent(Guid id);

        Student UpdateStudent(Student student);
        IEnumerable<Student> GetAllStudents();
    }
}