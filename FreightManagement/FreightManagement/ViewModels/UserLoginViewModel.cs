namespace FreightManagement.ViewModels
{
    public class UserLoginViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string UserId { get; set; }

        public string IdentityUserId { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
