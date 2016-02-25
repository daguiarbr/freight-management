using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class CarrierSearchViewModel
    {
        [Display(Name = "Razão Social")]
        public string CompanyName { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }
    }
}