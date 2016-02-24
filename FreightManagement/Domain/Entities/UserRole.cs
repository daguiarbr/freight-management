namespace Domain.Entities
{
    public class UserRole
    {
        public string UserId { get; set; }

        public string RoleId { get; set; }

        public string IdentityUserId { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
