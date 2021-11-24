using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class DrugRepository : IDrugRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public DrugRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadDrugDto> Get()
        {
            return _mapper.Map<IEnumerable<ReadDrugDto>>(_context.Drugs);
        }

        public ReadDrugDto GetById(int id)
        {
            Drug Drug = _context.Drugs.FirstOrDefault(x => x.Id.Equals(id));

            return _mapper.Map<ReadDrugDto>(Drug);
        }

        public ReadDrugDto Create(CreateDrugDto dto)
        {
            Drug Drug = _mapper.Map<Drug>(dto);

            _context.Drugs.Add(Drug);

            _context.SaveChanges();

            return _mapper.Map<ReadDrugDto>(Drug);
        }

        public Result Update(UpdateDrugDto dto, int id)
        {
            Drug Drug = _context.Drugs.FirstOrDefault(x => x.Id.Equals(id));

            if (Drug == null) return Result.Fail("Drug not found!");

            Drug = _mapper.Map(dto, Drug);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete(int id)
        {
            Drug Drug = _context.Drugs.FirstOrDefault(x => x.Id.Equals(id));

            if (Drug == null) return Result.Fail("Drug not found!");

            _context.Drugs.Remove(Drug);

            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
