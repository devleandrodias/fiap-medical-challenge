using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Order
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; } // Faz sentido aqui?

        [Required]
        public int PrescriptionId { get; set; } // Nao deve ser requerido

        [Required]
        public int DrugStorageId { get; set; }

        [Required] // Pensar em forma melhor para integração com aplicativo
        public string AppCode { get; set; } // Codigo do aplicativo
    }
}
