namespace Fiap.MedicalChallenge.Infrastructure.Dtos.Drug
{
    public class CreateDrugDto
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public bool IsRestrict { get; set; }
    }
}
