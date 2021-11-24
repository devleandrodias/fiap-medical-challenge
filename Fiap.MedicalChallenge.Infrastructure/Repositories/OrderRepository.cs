using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Contexts;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;

namespace Fiap.MedicalChallenge.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public OrderRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReadOrderDto> GetByDrugStorageId(int id)
        {
            return _mapper.Map<IEnumerable<ReadOrderDto>>(_context.Orders);
        }

        public ReadOrderDto GetById(int id)
        {
            Order order = _context.Orders.FirstOrDefault(x => x.Id.Equals(id));

            return _mapper.Map<ReadOrderDto>(order);
        }
    }
}
