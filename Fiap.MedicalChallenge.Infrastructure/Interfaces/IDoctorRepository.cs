using Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<ReadDoctorDto> Get();
        ReadDoctorDto GetById(int id);
        Result Delete(int id);
        ReadDoctorDto Create(CreateDoctorDto dto);
        Result Update(UpdateDoctorDto dto, int id);
    }
}
