using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Domain.Models
{
    public class Drug
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string Manufacturer { get; set; }

        [Required]
        public bool IsRestrict { get; set; }
     
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
