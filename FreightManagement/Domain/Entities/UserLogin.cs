namespace Domain.Entities
{
    public class UserLogin
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string UserId { get; set; }

        public string IdentityUserId { get; set; }
        public virtual User User { get; set; }
    }
}
