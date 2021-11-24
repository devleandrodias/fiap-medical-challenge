namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription
{
    public class ReadPrescriptionDto
    {
        public int Id { get; set; }

        public Domain.Models.Doctor Doctor { get; set; }

        public Domain.Models.Patient Patient { get; set; }

        public string Status { get; set; }
    }
}
