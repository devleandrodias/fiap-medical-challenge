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

        // 1R -> N -> Medicamentos

        [Required]
        public DateTime DueDate { get; set; }
    }
}
