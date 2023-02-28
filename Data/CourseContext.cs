using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_website.Models;
using Microsoft.EntityFrameworkCore;

namespace CS_website.Data
{
        public class CourseContext: DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
    }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    // {
    //     // connect to postgres with connection string from app settings
    //     options.UseNpgsql(Configuration.GetConnectionString("CourseLibraryDB"));
    // }
}