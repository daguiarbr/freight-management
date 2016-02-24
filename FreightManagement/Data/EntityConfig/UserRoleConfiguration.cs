using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.RoleId });

            // Properties
            Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.RoleId)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.IdentityUserId)
                .HasMaxLength(128)
                .HasColumnName("IdentityUser_Id");

            // Relationships
            HasRequired(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.RoleId);

            HasOptional(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.IdentityUserId);

        }
    }
}
