using OdenseUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdenseUniversity
{
    public class Address
    {
       // modelbuilder.Entity<Enrollment>().Haskey(e=>new{e.StudentId }{e.CourseId});
        public int Id { get; set; }
        public string Street{ get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }






    }
}
