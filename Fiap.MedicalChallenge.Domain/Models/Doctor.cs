using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Doctor
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string Name { get; set; }

        [Required, StringLength(14)]
        public string Cpf { get; set; }

        [Required, StringLength(14)]
        public string Crm { get; set; }
    }
}
