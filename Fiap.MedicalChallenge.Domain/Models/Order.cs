using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Order
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public int PrescriptionId { get; set; }

        [Required]
        public int DrugStorageId { get; set; }

        [Required]
        public string AppCode { get; set; }
    }
}
