using System.ComponentModel.DataAnnotations;
using FreightManagement.Enums;

namespace FreightManagement.ViewModels
{
    public class RatingSearchViewModel
    {
        [Display(Name = "Razão Social")]
        public string CompanyName { get; set; }

        [Display(Name = "Classificação:")]
        public RateType RateType { get; set; }
    }
}