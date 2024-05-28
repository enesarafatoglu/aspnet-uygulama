using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [EmailAddress]
        [Required(ErrorMessage = "E-mail is required.")]
        public String? Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "FirstName is required.")]   
        public String? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "LastName is required.")]   
        public String? LastName { get; set; } = string.Empty;

        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = string.Empty;   
        public DateTime ApplyAt { get; set; }

        public Candidate() //Constructor tanımladık
        {
            ApplyAt = DateTime.Now; //nesne üretilirken değeri atanıyor
        }
    }
}