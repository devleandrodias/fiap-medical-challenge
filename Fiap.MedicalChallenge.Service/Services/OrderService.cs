using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;
using Fiap.MedicalChallenge.Infrastructure.Interfaces;
using Fiap.MedicalChallenge.Service.Interfaces;

namespace Fiap.MedicalChallenge.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public ReadOrderDto Open(OpenOrderDto dto)
        {
            return _repository.Open(dto);
        }

        public ReadOrderDto Close(CloseOrderDto dto, int id)
        {
            return _repository.Close(dto, id);
        }

        public IEnumerable<ReadOrderDto> GetByDrugStorageId(int id)
        {
            return _repository.GetByDrugStorageId(id);
        }

        public ReadOrderDto GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
