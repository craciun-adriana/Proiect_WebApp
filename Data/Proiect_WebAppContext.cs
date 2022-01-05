using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_WebApp.Models;

namespace Proiect_WebApp.Data
{
    public class Proiect_WebAppContext : DbContext
    {
        public Proiect_WebAppContext (DbContextOptions<Proiect_WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<School> School { get; set; }

        public DbSet<Grade> Grade { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Discipline> Discipline { get; set; }

        public DbSet<Catalog> Catalog { get; set; }
    }
}

