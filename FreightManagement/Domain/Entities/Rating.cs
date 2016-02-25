using System;

namespace Domain.Entities
{
    public class Rating
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int RateType { get; set; }

        public string Message { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
