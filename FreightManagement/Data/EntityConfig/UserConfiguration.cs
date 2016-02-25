using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.Email)
                .HasMaxLength(256);

            Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Discriminator)
                .IsRequired()
                .HasMaxLength(128);

        }
    }
}
