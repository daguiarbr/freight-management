using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class CarrierPhoneNumber
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }

        public PhoneType PhoneType { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
