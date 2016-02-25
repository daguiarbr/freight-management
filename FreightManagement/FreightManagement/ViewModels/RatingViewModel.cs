using FreightManagement.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class RatingViewModel
    {
        [Key]
        [Display(Name = "Código:")]
        public int Id { get; set; }

        [Display(Name = "Transportadora:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public int CarrierId { get; set; }
        public virtual CarrierViewModel Carrier { get; set; }

        [Display(Name = "Transportadora:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string UserId { get; set; }
        public virtual UserViewModel User { get; set; }

        [Display(Name = "Classificação:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public RateType RateType { get; set; }

        [Display(Name = "Observação:")]
        public string Message { get; set; }

        [Display(Name = "Data Cadastro:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }
    }
}
