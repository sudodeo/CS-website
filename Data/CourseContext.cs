using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CS_website.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext()
        {
        }

        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }

        public void Seed()
        {
            using (var reader = new StreamReader("Scripts/PopulateDB.sql"))
            {
                string sql = reader.ReadToEnd();
                Database.ExecuteSqlRaw(sql);
            }
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     // connect to postgres with connection string from app settings
        //     options.UseNpgsql(Configuration.GetConnectionString("CourseLibraryDB"));
        // }
    }


}