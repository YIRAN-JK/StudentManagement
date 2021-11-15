using System.Collections;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Group
    {
        public int Id { set; get; }
        
        public string Name { set; get; }
        
        public string Note { set; get; }
        
        public ICollection<Student> Students { set; get; }
    }
}