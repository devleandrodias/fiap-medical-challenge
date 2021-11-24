using Microsoft.EntityFrameworkCore;
using Fiap.MedicalChallenge.Domain.Models;

namespace Fiap.MedicalChallenge.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<DbContext> opt) : base(opt) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Drug> Drugs { get; set; }

        public DbSet<Drugstorage> DrugStorages { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}
