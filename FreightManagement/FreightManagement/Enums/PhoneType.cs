using System.ComponentModel.DataAnnotations;

namespace FreightManagement.Enums
{
    public enum PhoneType
    {
        [Display(Name = @"Comercial")]
        Commercial = 0,
        [Display(Name = @"Fax")]
        Fax = 1,
        [Display(Name = @"Celular")]
        Mobile = 2,
        [Display(Name = @"Outros")]
        Other = 3
    }
}
