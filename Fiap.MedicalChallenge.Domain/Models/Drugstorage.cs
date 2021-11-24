using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Drugstorage
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string SocialName { get; set; }

        [Required, StringLength(150)]
        public string FantsyName { get; set; }

        [Required, StringLength(18)]
        public string Cnpj { get; set; }
    }
}
