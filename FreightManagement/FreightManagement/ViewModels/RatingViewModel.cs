using FreightManagement.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public virtual CarrierViewModel Carrier { get; set; }

        public RateType Rate { get; set; }

        public string Message { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
    }
}
