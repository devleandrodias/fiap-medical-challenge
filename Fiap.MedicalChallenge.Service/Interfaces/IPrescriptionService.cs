using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IPrescriptionService
    {
        ReadPrescriptionDto GetById(int id);
        IEnumerable<ReadPrescriptionDto> GetByDoctorId(int id);
        IEnumerable<ReadPrescriptionDto> GetByPatientId(int id);
        ReadPrescriptionDto Create(CreatePrescriptionDto dto);
    }
}
