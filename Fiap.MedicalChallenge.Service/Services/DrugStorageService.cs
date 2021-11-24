using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class DrugStorageService : IDrugStorageService
    {
        private readonly IDrugStorageRepository _repository;

        public DrugStorageService(IDrugStorageRepository repository)
        {
            _repository = repository;
        }

        public ReadDrugStorageDto Create(CreateDrugStorageDto dto)
        {
            return _repository.Create(dto);
        }

        public Result Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<ReadDrugStorageDto> Get()
        {
            return _repository.Get();
        }

        public ReadDrugStorageDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Result Update(UpdateDrugStorageDto dto, int id)
        {
            return _repository.Update(dto, id);
        }
    }
}
