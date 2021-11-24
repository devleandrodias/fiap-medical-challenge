using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Prescription
    {
        public Prescription()
        {
            Status = "OPEN";
        }

        [Required, Key]
        public int Id { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
