using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Data.Context
{
  public  class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
       :base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
