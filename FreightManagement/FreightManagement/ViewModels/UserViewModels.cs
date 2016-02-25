using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class UserViewModel
    {
        [Key]
        [Display(Name = "Código:")]
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

        public string Discriminator { get; set; }

        public virtual ICollection<RatingViewModel> Ratings { get; set; }

        public virtual ICollection<UserClaimViewModel> UserClaims { get; set; }

        public virtual ICollection<UserLoginViewModel> UserLogins { get; set; }

        public virtual ICollection<UserRoleViewModel> UserRoles { get; set; }
    }
}
