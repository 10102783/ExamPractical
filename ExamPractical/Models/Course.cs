using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPractical.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(1, 10)]
        public int Credits { get; set; }

        [ForeignKey("Lecturer")]
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
