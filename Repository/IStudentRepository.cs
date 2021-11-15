using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public interface IStudentRepository
    {
        int AddStudent(Student student);

        Student SearchStudent(int id);
        
        Student DeleteStudent(int id);

        Student UpdateStudent(Student student);
        List<Student> GetAllStudents();
    }
}