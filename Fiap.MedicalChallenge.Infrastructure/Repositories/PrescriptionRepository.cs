using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public PrescriptionRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPrescriptionDto Create(CreatePrescriptionDto dto)
        {
            Prescription prescription = _mapper.Map<Prescription>(dto);

            _context.Prescriptions.Add(prescription);

            _context.SaveChanges();

            return _mapper.Map<ReadPrescriptionDto>(prescription);
        }

        public ReadPrescriptionDto GetById(int id)
        {
            Prescription prescription = _context.Prescriptions.FirstOrDefault(p => p.Id.Equals(id));

            return _mapper.Map<ReadPrescriptionDto>(prescription);
        }

        public IEnumerable<ReadPrescriptionDto> GetByDoctorId(int id)
        {
            return _mapper.Map<IEnumerable<ReadPrescriptionDto>>(_context.Prescriptions.Where(x => x.DoctorId.Equals(id)));
        }

        public IEnumerable<ReadPrescriptionDto> GetByPatientId(int id)
        {
            return _mapper.Map<IEnumerable<ReadPrescriptionDto>>(_context.Prescriptions.Where(x => x.PatientId.Equals(id)));
        }
    }
}
