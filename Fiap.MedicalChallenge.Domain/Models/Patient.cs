using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Patient
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        [Required, StringLength(14)]
        public string Cpf { get; set; }
    }
}
