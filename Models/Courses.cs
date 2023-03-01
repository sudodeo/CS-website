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
        [Column("code")]
        public string Code { get; set; } = null!;

        [Column("level")]
        public string Level { get; set; } = null!;

        [Column("title")]
        public string Title { get; set; } = null!;

        [Column("description")]
        public string Description { get; set; } = null!;

        [Column("status")]
        public string Status { get; set; } = null!;

        [Column("units")]
        public string Units { get; set; } = null!;
    }
}
