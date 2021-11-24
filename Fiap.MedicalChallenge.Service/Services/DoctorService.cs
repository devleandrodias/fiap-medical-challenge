using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;

        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ReadDoctorDto> Get()
        {
            return _repository.Get();
        }

        public ReadDoctorDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Result Delete(int id)
        {
            return _repository.Delete(id);
        }

        public ReadDoctorDto Create(CreateDoctorDto dto)
        {
            return _repository.Create(dto);
        }

        public Result Update(UpdateDoctorDto dto, int id)
        {
            return _repository.Update(dto, id);
        }
    }
}
