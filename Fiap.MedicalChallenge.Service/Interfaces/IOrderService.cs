using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;

namespace Fiap.MedicalChallenge.Service.Interfaces
{
    public interface IOrderService
    {
        ReadOrderDto Open(OpenOrderDto dto);
        ReadOrderDto Close(CloseOrderDto dto, int id);
        ReadOrderDto GetById(int id);
        IEnumerable<ReadOrderDto> GetByDrugStorageId(int id);
    }
}
