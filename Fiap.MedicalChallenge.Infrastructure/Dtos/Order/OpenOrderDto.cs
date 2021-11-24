namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Order
{
    public class OpenOrderDto
    {
        public int PrescriptionId { get; set; }

        public int DrugStorageId { get; set; }
        
        public string AppCode { get; set; }

        public string Status { get; set; }
    }
}
