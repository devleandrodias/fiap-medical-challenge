using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public DoctorRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadDoctorDto> Get()
        {
            return _mapper.Map<IEnumerable<ReadDoctorDto>>(_context.Doctors);
        }

        public ReadDoctorDto GetById(int id)
        {
            Doctor doctor = _context.Doctors.FirstOrDefault(x => x.Id.Equals(id));

            return _mapper.Map<ReadDoctorDto>(doctor);
        }

        public ReadDoctorDto Create(CreateDoctorDto dto)
        {
            Doctor doctor = _mapper.Map<Doctor>(dto);

            _context.Doctors.Add(doctor);

            _context.SaveChanges();

            return _mapper.Map<ReadDoctorDto>(doctor);
        }

        public Result Update(UpdateDoctorDto dto, int id)
        {
            Doctor doctor = _context.Doctors.FirstOrDefault(x => x.Id.Equals(id));

            if (doctor == null) return Result.Fail("Doctor not found!");

            doctor = _mapper.Map(dto, doctor);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete(int id)
        {
            Doctor doctor = _context.Doctors.FirstOrDefault(x => x.Id.Equals(id));

            if (doctor == null) return Result.Fail("Doctor not found!");

            _context.Doctors.Remove(doctor);

            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
