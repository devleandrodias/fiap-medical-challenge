using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using FluentResults;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class DrugStorageRepository : IDrugStorageRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public DrugStorageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadDrugStorageDto> Get()
        {
            return _mapper.Map<IEnumerable<ReadDrugStorageDto>>(_context.DrugStorages);
        }

        public ReadDrugStorageDto GetById(int id)
        {
            DrugStorage DrugStorage = _context.DrugStorages.FirstOrDefault(x => x.Id.Equals(id));

            return _mapper.Map<ReadDrugStorageDto>(DrugStorage);
        }

        public ReadDrugStorageDto Create(CreateDrugStorageDto dto)
        {
            DrugStorage DrugStorage = _mapper.Map<DrugStorage>(dto);

            _context.DrugStorages.Add(DrugStorage);

            _context.SaveChanges();

            return _mapper.Map<ReadDrugStorageDto>(DrugStorage);
        }

        public Result Update(UpdateDrugStorageDto dto, int id)
        {
            DrugStorage DrugStorage = _context.DrugStorages.FirstOrDefault(x => x.Id.Equals(id));

            if (DrugStorage == null) return Result.Fail("Drug Storage not found!");

            DrugStorage = _mapper.Map(dto, DrugStorage);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete(int id)
        {
            DrugStorage DrugStorage = _context.DrugStorages.FirstOrDefault(x => x.Id.Equals(id));

            if (DrugStorage == null) return Result.Fail("Drug Storage not found!");

            _context.DrugStorages.Remove(DrugStorage);

            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
