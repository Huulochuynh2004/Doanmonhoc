using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }
}