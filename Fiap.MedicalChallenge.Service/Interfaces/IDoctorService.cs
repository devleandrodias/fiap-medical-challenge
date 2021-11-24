using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor;
using FluentResults;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IDoctorService
    {
        IEnumerable<ReadDoctorDto> Get();
        ReadDoctorDto GetById(int id);
        Result Delete(int id);
        ReadDoctorDto Create(CreateDoctorDto dto);
        Result Update(UpdateDoctorDto dto, int id);
    }
}
