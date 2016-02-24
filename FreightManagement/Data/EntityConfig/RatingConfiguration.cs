using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class RatingConfiguration : EntityTypeConfiguration<Rating>
    {
        public RatingConfiguration()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.CarrierId);

            // Properties
            Property(t => t.UserId)
                .HasMaxLength(128);

            Property(t => t.Rate)
                .IsRequired();

            Property(t => t.Message)
                .HasMaxLength(256);

            // Relationships
            HasRequired(t => t.Carrier)
                .WithMany(t => t.Ratings)
                .HasForeignKey(d => d.CarrierId);

            HasRequired(t => t.User)
                .WithMany(t => t.Ratings)
                .HasForeignKey(d => d.UserId);
        }
    }
}
