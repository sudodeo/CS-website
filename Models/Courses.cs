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
        public string code { get; set; }
        public string level { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string units { get; set; }
    }

}