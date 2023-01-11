using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace CS_website.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public string CourseStatus { get; set; }
    }

    public class CourseContext: DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}