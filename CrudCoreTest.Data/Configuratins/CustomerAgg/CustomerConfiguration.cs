using CrudCoreTest.Domain.CustomerAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCoreTest.Data.Configuratins.CustomerAgg
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FirstName).HasMaxLength(50);
            builder.Property(m => m.LastName).HasMaxLength(50);
            builder.Property(m => m.DateOfBirth).HasColumnType("date");
            builder.Property(m => m.PhoneNumber).HasColumnType("varchar").HasMaxLength(11);
            builder.Property(m => m.Email).HasMaxLength(50); ;
            builder.Property(m => m.BankAccountNumber);

            builder
                .HasIndex(p => p.Email)
                .IsUnique();
            builder
                .HasIndex(p => new { p.FirstName, p.LastName, p.DateOfBirth })
                .IsUnique();

            builder.ToTable("Customer");
        }
    }
}
