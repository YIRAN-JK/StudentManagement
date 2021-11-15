using System;

namespace WebApplication.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public Gender Gender { get; set; }
        
        public string Note { get; set; }
        
        public Group Group { get; set; }
    }
}