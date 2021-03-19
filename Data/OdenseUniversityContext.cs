using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OdenseUniversity.Models;

namespace OdenseUniversity.Data
{
    public class OdenseUniversityContext : DbContext
    {

        public DbSet<Student> Student { get; set; }
        public OdenseUniversityContext (DbContextOptions<OdenseUniversityContext> options)
            : base(options)
        {
        }

    }
}
