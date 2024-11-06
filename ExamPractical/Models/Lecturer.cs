using System.ComponentModel.DataAnnotations;

namespace ExamPractical.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Department { get; set; }
    }
}

