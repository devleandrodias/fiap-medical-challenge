using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Patient;

namespace Fiap.MedicalChallenge.Infrastructure.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<CreatePatientDto, Patient>();
            CreateMap<UpdatePatientDto, Patient>();
            CreateMap<Patient, ReadPatientDto>();
        }
    }
}
