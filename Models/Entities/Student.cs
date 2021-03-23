﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdenseUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName}{LastName}";

        public ICollection<Enrollment> Enrollments { get; set; }

        public Address Address { get; set; }
        public ICollection<Course> Courses{ get; set; }
        

    }
}
