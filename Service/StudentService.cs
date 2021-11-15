using WebApplication.Repository;

namespace WebApplication.Service
{
    public class StudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
    }
}