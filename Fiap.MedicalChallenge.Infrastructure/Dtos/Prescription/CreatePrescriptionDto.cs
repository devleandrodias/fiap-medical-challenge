namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription
{   
    public class CreatePrescriptionDto
    {
        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public DateTime DueDate { get; set; }

        public List<int> DrugsIds { get; set; }
    }
}
