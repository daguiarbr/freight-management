using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class RatingLinkConfiguration : EntityTypeConfiguration<Rating>
    {
        public RatingLinkConfiguration()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.CarrierId);

            Property(t => t.Rate)
                .IsRequired();

            Property(t => t.Message)
                .HasMaxLength(256);

            // Relationships
            HasRequired(t => t.Carrier)
                .WithMany(t => t.Ratings)
                .HasForeignKey(d => d.CarrierId);            
        }
    }
}
