using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IOrderRepository
    {
        void Open();
        void Close();
        ReadOrderDto GetById(int id);
        IEnumerable<ReadOrderDto> GetByDrugStorageId(int id);
    }
}
