using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IDrugRepository
    {
        IEnumerable<ReadDrugDto> Get();
        ReadDrugDto GetById(int id);
        Result Delete(int id);
        ReadDrugDto Create(CreateDrugDto dto);
        Result Update(UpdateDrugDto dto, int id);
    }
}
