using Fiap.MedicalChallenge.Infrastructure.Dtos.Patient;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<ReadPatientDto> Get();
        ReadPatientDto GetById(int id);
        Result Delete(int id);
        ReadPatientDto Create(CreatePatientDto dto);
        Result Update(UpdatePatientDto dto, int id);
    }
}
