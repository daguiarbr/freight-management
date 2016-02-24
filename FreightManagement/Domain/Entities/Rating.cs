using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class Rating
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }

        public RateType Rate { get; set; }

        public string Message { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
