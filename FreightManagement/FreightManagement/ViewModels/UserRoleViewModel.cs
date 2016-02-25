using Domain.Entities;

namespace FreightManagement.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }

        public string RoleId { get; set; }

        public string IdentityUserId { get; set; }

        public virtual RoleViewModel Role { get; set; }

        public virtual UserViewModel User { get; set; }
    }
}
