using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly IPrescriptionRepository _repository;

        public PrescriptionService(IPrescriptionRepository repository)
        {
            _repository = repository;
        }

        public ReadPrescriptionDto Create(CreatePrescriptionDto dto)
        {
            return _repository.Create(dto);
        }

        public ReadPrescriptionDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<ReadPrescriptionDto> GetByDoctorId(int id)
        {
            return _repository.GetByDoctorId(id);
        }

        public IEnumerable<ReadPrescriptionDto> GetByPatientId(int id)
        {
            return _repository.GetByPatientId(id);
        }
    }
}
