using Microsoft.EntityFrameworkCore;
using Fiap.MedicalChallenge.Domain.Models;

namespace Fiap.MedicalChallenge.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<DbContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Prescription>()
                .HasMany(b => b.Drugs)
                .WithMany(c => c.Prescriptions)
                .UsingEntity(j => j.ToTable("PrescriptionDrugs"));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Drug> Drugs { get; set; }

        public DbSet<DrugStorage> DrugStorages { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
