using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data.Entities;

namespace PlatigeImage.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contractor>()
                .HasMany(k => k.Invoices)
                .WithOne(f => f.Contractor)
                .HasForeignKey(f => f.ContractorId);
        }
    }
}
