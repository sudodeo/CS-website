using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace CS_website.Models
{
    [Table("courses", Schema = "public")]
    public class Course
    {
        [Key]
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public string CourseStatus { get; set; }
        public string Level { get; set; }
    }

}