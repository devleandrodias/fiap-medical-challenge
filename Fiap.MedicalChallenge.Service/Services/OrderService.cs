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

        public void Open()
        {
            _repository.Open();
        }

        public void Close()
        {
            _repository.Close();
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
