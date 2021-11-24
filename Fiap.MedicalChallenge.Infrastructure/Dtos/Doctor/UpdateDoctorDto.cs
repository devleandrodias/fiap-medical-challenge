using System.ComponentModel.DataAnnotations;

namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor
{
    public class UpdateDoctorDto
    {
        public string Name { get; set; }

        public string Cpf { get; set; }

        public string Crm { get; set; }
    }
}
