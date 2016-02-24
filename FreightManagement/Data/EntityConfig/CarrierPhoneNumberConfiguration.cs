using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class CarrierPhoneNumberConfiguration : EntityTypeConfiguration<CarrierPhoneNumber>
    {
        public CarrierPhoneNumberConfiguration()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.CarrierId);

            Property(t => t.PhoneType)
                .IsRequired();

            Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            // Relationships
            HasRequired(t => t.Carrier)
                .WithMany(t => t.CarrierPhoneNumbers)
                .HasForeignKey(d => d.CarrierId);
        }
    }
}
