using System.ComponentModel.DataAnnotations;

namespace FreightManagement.Enums
{
    public enum RateType
    {
        [Display(Name = @"Ruim ou Péssima")]
        Negative = 0,
        [Display(Name = @"Neutra ou Imparcial")]
        Impartial = 1,
        [Display(Name = @"Boa ou Ótima")]
        Positive = 2,
    }
}
