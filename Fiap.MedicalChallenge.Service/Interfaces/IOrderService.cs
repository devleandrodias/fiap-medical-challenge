using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IOrderService
    {
        void Open();
        void Close();
        ReadOrderDto GetById(int id);
        IEnumerable<ReadOrderDto> GetByDrugStorageId(int id);
    }
}
