using System.ComponentModel.DataAnnotations;

namespace ClaimsSubmissionApp.Models
{
    public class Claim
    {
        public int Id { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        [Range(1, 100)]
        public int HoursWorked { get; set; }

        [Required]
        [Range(1, 100)]
        public decimal HourlyRate { get; set; }

        public string AdditionalNotes { get; set; }

        public string Status { get; set; } = "Pending";
    }
}