using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class UserLoginConfiguration : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfiguration()
        {
            // Primary Key
            HasKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });

            // Properties
            Property(t => t.LoginProvider)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.ProviderKey)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.IdentityUserId)
                .HasMaxLength(128)
                .HasColumnName("IdentityUser_Id");

            // Relationships
            HasOptional(t => t.User)
                .WithMany(t => t.UserLogins)
                .HasForeignKey(d => d.IdentityUserId);

        }
    }
}
