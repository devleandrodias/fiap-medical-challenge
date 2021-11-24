using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;

namespace Fiap.MedicalChallenge.Infrastructure.Profiles
{
    public class PrescriptionProfile : Profile
    {
        public PrescriptionProfile()
        {
            CreateMap<CreatePrescriptionDto, Prescription>();
            CreateMap<Prescription, ReadPrescriptionDto>();
        }
    }
}
