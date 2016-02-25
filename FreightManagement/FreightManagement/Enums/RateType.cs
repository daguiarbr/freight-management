using System.ComponentModel.DataAnnotations;

namespace FreightManagement.Enums
{
    public enum RateType
    {
        [Display(Name = @"Ruim ou Péssima")]
        Negative = 0,
        [Display(Name = @"Não tenho certeza")]
        Impartial = 1,
        [Display(Name = @"Boa ou Ótima")]
        Positive = 2,
    }
}
