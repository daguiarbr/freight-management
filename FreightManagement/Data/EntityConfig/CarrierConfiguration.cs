using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class CarrierConfiguration : EntityTypeConfiguration<Carrier>
    {
        public CarrierConfiguration()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.TradingName)
                .IsRequired();

            Property(t => t.Cnpj)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Ie)
                .HasMaxLength(20);

            Property(t => t.Email)
                .HasMaxLength(256);

            Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Number)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Complement)
                .HasMaxLength(20);

            Property(t => t.Neighborhood)
                .IsRequired()
                .HasMaxLength(80);

            Property(t => t.Cep)
                .IsRequired()
                .HasMaxLength(9);

            Property(t => t.City)
                .HasMaxLength(100);

            Property(t => t.State)
                .IsRequired();
        }
    }
}
