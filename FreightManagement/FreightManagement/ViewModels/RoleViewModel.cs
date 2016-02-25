using System.Collections.Generic;

namespace FreightManagement.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserRoleViewModel> UserRoles { get; set; }
    }
}
