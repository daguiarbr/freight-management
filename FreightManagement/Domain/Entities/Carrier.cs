using System;
using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities
{
    public class Carrier
    {
        public int Id { get; set; }

        public PersonType PersonType { get; set; }

        public string CompanyName { get; set; }

        public string TradingName { get; set; }

        public string CpfCnpj { get; set; }

        public string RgIe { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string Neighborhood { get; set; }

        public string Cep { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ICollection<CarrierPhoneNumber> CarrierPhoneNumbers { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
