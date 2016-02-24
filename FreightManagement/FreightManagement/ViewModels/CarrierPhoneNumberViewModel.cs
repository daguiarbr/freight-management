using Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class CarrierPhoneNumberViewModel
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public virtual CarrierViewModel Carrier { get; set; }

        public PhoneType PhoneType { get; set; }

        public string PhoneNumber { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
    }
}
