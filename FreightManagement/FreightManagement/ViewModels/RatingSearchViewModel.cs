using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class RatingSearchViewModel
    {
        [Display(Name = "Razão Social")]
        public string CompanyName { get; set; }

        [Display(Name = "Classificação:")]
        public int? RateType { get; set; }
    }
}