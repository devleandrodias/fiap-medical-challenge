using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class DrugStorage
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string SocialName { get; set; }

        [Required, StringLength(150)]
        public string FantsyName { get; set; }

        [Required, StringLength(18)]
        public string Cnpj { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
