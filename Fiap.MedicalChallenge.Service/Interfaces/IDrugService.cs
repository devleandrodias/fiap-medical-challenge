using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IDrugService
    {
        IEnumerable<ReadDrugDto> Get();
        ReadDrugDto GetById(int id);
        Result Delete(int id);
        ReadDrugDto Create(CreateDrugDto dto);
        Result Update(UpdateDrugDto dto, int id);
    }
}
