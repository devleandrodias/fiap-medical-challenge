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

            builder.Entity<Prescription>()
                .HasOne(x => x.Doctor)
                .WithMany(x => x.Prescriptions)
                .HasForeignKey(x => x.DoctorId);

            builder.Entity<Prescription>()
                .HasOne(x => x.Patient)
                .WithMany(x => x.Prescriptions)
                .HasForeignKey(x => x.PatientId);

            builder.Entity<Order>()
                .HasOne(x => x.DrugStorage)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.DrugStorageId);

            builder.Entity<Order>()
                .HasOne(x => x.Prescription)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.PrescriptionId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer("Data Source=srv-fiap-medical-challenge.database.windows.net;Initial Catalog=db-medical-challenge;Persist Security Info=True;User ID=fiap;Password=44OMMzkzWZ&J%SsfmG67");
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
