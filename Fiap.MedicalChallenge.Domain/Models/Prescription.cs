using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

        public virtual Doctor Doctor { get; set; }

        [Required]
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Status { get; set; }


        [JsonIgnore]
        public virtual IEnumerable<Order> Orders { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
