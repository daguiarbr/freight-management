using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class UserClaimConfiguration : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.IdentityUserId)
                .HasMaxLength(128)
                .HasColumnName("IdentityUser_Id");


            // Relationships
            HasOptional(t => t.User)
                .WithMany(t => t.UserClaims)
                .HasForeignKey(d => d.IdentityUserId);

        }
    }
}
