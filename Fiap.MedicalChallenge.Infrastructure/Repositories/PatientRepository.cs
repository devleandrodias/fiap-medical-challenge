using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Patient;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public PatientRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadPatientDto> Get()
        {
            return _mapper.Map<IEnumerable<ReadPatientDto>>(_context.Patients);
        }

        public ReadPatientDto GetById(int id)
        {
            Patient Patient = _context.Patients.FirstOrDefault(x => x.Id.Equals(id));

            return _mapper.Map<ReadPatientDto>(Patient);
        }

        public ReadPatientDto Create(CreatePatientDto dto)
        {
            Patient Patient = _mapper.Map<Patient>(dto);

            _context.Patients.Add(Patient);

            _context.SaveChanges();

            return _mapper.Map<ReadPatientDto>(Patient);
        }

        public Result Update(UpdatePatientDto dto, int id)
        {
            Patient Patient = _context.Patients.FirstOrDefault(x => x.Id.Equals(id));

            if (Patient == null) return Result.Fail("Drug Storage not found!");

            Patient = _mapper.Map(dto, Patient);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete(int id)
        {
            Patient Patient = _context.Patients.FirstOrDefault(x => x.Id.Equals(id));

            if (Patient == null) return Result.Fail("Drug Storage not found!");

            _context.Patients.Remove(Patient);

            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
