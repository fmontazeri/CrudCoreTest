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
            builder.Property(m => m.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(m => m.LastName).HasMaxLength(50).IsRequired();
            builder.Property(m => m.DateOfBirth).HasColumnType("date").IsRequired();
            //builder.Property(m => m.PhoneNumber).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            builder.Property(m => m.PhoneNumber).HasMaxLength(11).IsRequired();
            builder.Property(m => m.Email).HasMaxLength(50).IsRequired();
            builder.Property(m => m.BankAccountNumber).IsRequired(); 

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
