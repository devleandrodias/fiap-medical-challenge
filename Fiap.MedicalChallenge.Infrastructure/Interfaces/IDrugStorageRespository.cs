using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IDrugStorageRepository
    {
        IEnumerable<ReadDrugStorageDto> Get();
        ReadDrugStorageDto GetById(int id);
        Result Delete(int id);
        ReadDrugStorageDto Create(CreateDrugStorageDto dto);
        Result Update(UpdateDrugStorageDto dto, int id);
    }
}
