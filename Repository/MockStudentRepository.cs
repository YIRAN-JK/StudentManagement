using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public MockStudentRepository(List<Student> students)
        {
            _students = students;
        }

        public MockStudentRepository()
        {
            if (_students == null || _students.Count <= 0)
            {
                InitializeStudents();
            }
        }

        private void InitializeStudents()
        {
            _students = new List<Student>
            {
                new Student
                {
                    Id = new Guid(),
                    Name = "Tom",
                    Gender = Gender.Male,
                    Note = "fresh"
                },
                new Student
                {
                    Id = new Guid(),
                    Name = "Jerry",
                    Gender = Gender.Female,
                    Note = "fresh"
                }
            };
        }

        public Guid AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student SearchStudent(Guid id)
        {
            //linq(命令式vs函数式)
            return _students.FirstOrDefault(n => n.Id == id);
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
            return _students;
        }
    }
}