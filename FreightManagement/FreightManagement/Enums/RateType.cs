using System.ComponentModel.DataAnnotations;

namespace FreightManagement.Enums
{
    public enum RateType
    {
        [Display(Name = @"Negativa")]
        Negative = 0,
        [Display(Name = @"Neutra")]
        Impartial = 1,
        [Display(Name = @"Positiva")]
        Positive = 2,
    }
}
