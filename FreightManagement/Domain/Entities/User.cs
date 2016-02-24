using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public string HastaId { get; set; }

        public string Name { get; set; }

        public string DocumentNumber { get; set; }

        public bool Vip { get; set; }

        public string VipMessage { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public string Discriminator { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
