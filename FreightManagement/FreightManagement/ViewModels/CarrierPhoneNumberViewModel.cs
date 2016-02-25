using FreightManagement.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class CarrierPhoneNumberViewModel
    {
        [Key]
        [Display(Name = "Código:")]
        public int Id { get; set; }

        [Display(Name = "Transportadora:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public int CarrierId { get; set; }
        public virtual CarrierViewModel Carrier { get; set; }

        [Display(Name = "Tipo de Telefone:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public PhoneType PhoneType { get; set; }

        [Display(Name = "Número:")]
        [MaxLength(20, ErrorMessage = "Campo {0} deve ter no máximo 20 caracteres")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Data Cadastro:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }
    }
}
