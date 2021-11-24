using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IDrugStorageService
    {
        IEnumerable<ReadDrugStorageDto> Get();
        ReadDrugStorageDto GetById(int id);
        Result Delete(int id);
        ReadDrugStorageDto Create(CreateDrugStorageDto dto);
        Result Update(UpdateDrugStorageDto dto, int id);
    }
}
