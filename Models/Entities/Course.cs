using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdenseUniversity.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

         public ICollection<Enrollment> Enrollments { get; set; }
        //Många till många
        //public ICollection<Student> Students { get; set; }
    }
}
