using Fiap.MedicalChallenge.Infrastructure.Dtos.Patient;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public ReadPatientDto Create(CreatePatientDto dto)
        {
            return _repository.Create(dto);
        }

        public Result Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<ReadPatientDto> Get()
        {
            return _repository.Get();
        }

        public ReadPatientDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Result Update(UpdatePatientDto dto, int id)
        {
            return _repository.Update(dto, id);
        }
    }
}
