using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class DrugService : IDrugService
    {
        private readonly IDrugRepository _repository;

        public DrugService(IDrugRepository repository)
        {
            _repository = repository;
        }

        public ReadDrugDto Create(CreateDrugDto dto)
        {
            return _repository.Create(dto);
        }

        public Result Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<ReadDrugDto> Get()
        {
            return _repository.Get();
        }

        public ReadDrugDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Result Update(UpdateDrugDto dto, int id)
        {
            return _repository.Update(dto, id);
        }
    }
}
