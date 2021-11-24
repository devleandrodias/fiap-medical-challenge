using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Order
    {
        public Order()
        {
            Status = "OPEN";
        }

        [Required, Key]
        public int Id { get; set; }

        [Required]
        public int PrescriptionId { get; set; }

        public virtual Prescription Prescription { get; set; }

        [Required]
        public int DrugStorageId { get; set; }

        public virtual DrugStorage DrugStorage { get; set; }

        [Required]
        public string AppCode { get; set; }

        public string Status { get; set; }
    }
}
