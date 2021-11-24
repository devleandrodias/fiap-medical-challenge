using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Prescription
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
