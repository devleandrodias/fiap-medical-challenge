using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;

namespace Fiap.MedicalChallenge.Infrastructure.Interfaces
{
    public interface IOrderRepository
    {
        ReadOrderDto Open(OpenOrderDto dto);
        ReadOrderDto Close(CloseOrderDto dto, int id);
        ReadOrderDto GetById(int id);
        IEnumerable<ReadOrderDto> GetByDrugStorageId(int id);
    }
}
