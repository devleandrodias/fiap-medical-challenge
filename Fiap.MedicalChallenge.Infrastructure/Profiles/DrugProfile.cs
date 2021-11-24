using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;

namespace Fiap.MedicalChallenge.Infrastructure.Profiles
{
    public class DrugProfile : Profile
    {
        public DrugProfile()
        {
            CreateMap<CreateDrugDto, Drug>();
            CreateMap<UpdateDrugDto, Drug>();
            CreateMap<Drug, ReadDrugDto>();
        }
    }
}
