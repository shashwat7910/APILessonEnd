using APILessonEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILessonEnd
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Student> students { get; set; }

    }
}
