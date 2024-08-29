using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data.Entities;

namespace PlatigeImage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        
       
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
