namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Order
{
    public class ReadOrderDto
    {
        public int Id { get; set; }
        public Domain.Models.DrugStorage DrugStorage { get; set; }
        public Domain.Models.Prescription Prescription { get; set; }
    }
}
