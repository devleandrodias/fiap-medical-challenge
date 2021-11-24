namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Drug
{
    public class ReadDrugDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public bool IsRestrict { get; set; }
    }
}
