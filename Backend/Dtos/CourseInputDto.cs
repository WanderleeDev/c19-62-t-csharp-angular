using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.models;
using System.ComponentModel.DataAnnotations;

namespace Backend.Dtos
{
    public class CourseInputDto
    {
        [Required] 
        public int IdCategory {get; set; }

        [Required] 
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Prerequisites { get; set; } = string.Empty;
        [Required]
        public string BulletPoints { get; set; } = string.Empty;
        [Required]
        public short DurationHours { get; set; }
    }
}