using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IPrescriptionRepository
    {
        ReadPrescriptionDto GetById(int id);
        IEnumerable<ReadPrescriptionDto> GetByDoctorId(int id);
        IEnumerable<ReadPrescriptionDto> GetByPatientId(int id);
        ReadPrescriptionDto Create(CreatePrescriptionDto dto);
    }
}
