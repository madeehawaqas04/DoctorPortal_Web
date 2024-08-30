using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorPortal_DotNetCore.Models.Dto
{
    public class AppointmentDto
    {

        [Required]
        [ForeignKey("IdentityUser")]
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        [Display(Name = "Patient")]
        public int PatientId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";

    }
}
