using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Data.Entities;
namespace SchoolManagementSystem.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
       
        [Required]
        public string AdmissionNumber { get; set; } = null!;

        [Display (Name = "Name")]
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateOnly? DateOfBirth { get; set; }
       
        [DataType(DataType.Date)]
        public DateOnly? JoinedDate { get; set; }

        public string? Email { get; set; }

        public int? PhoneNumber { get; set; }

        public string? About { get; set; }

        [Display(Name = "Gender")]
        public string GenderType { get; set; } = null!;

        [Display(Name ="Address")]
        public string? Address1 { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string? ZipCode { get; set; }

        public string? Country { get; set; }

    }
}
