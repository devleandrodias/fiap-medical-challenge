using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;

namespace Fiap.MedicalChallenge.Infrastructure.Profiles
{
    public class DrugStorageProfile : Profile
    {
        public DrugStorageProfile()
        {
            CreateMap<CreateDrugStorageDto, DrugStorage>();
            CreateMap<UpdateDrugStorageDto, DrugStorage>();
            CreateMap<DrugStorage, ReadDrugStorageDto>();
        }
    }
}
