using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab7.Models
{
    public class UniversityCampus
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } // Navigation property
    }
}