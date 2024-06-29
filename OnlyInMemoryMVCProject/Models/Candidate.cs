using System.ComponentModel.DataAnnotations;

namespace OnlyInMemoryMVCProject.Models
{
    
    public class Candidate
    {
        //Burada required sistemi tam olarak yapılmamıştır bitmesi gerekmektedir.
        [Required(ErrorMessage = "E mail is required")]
        public String? EMail { get; set; } = string.Empty;
        [Required(ErrorMessage ="First Name is required")]
        public String? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Last Name is required")]
        public String? LastName { get; set; } = string.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public String? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; } 
        public int? age { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }    
}