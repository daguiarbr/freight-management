using FreightManagement.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreightManagement.ViewModels
{
    public class CarrierViewModel
    {
        [Key]
        [Display(Name = "Código:")]
        public int Id { get; set; }

        [Display(Name = "Razão Social:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo {0} deve ter entre 5 e 150 caracteres")]
        public string CompanyName { get; set; }

        [Display(Name = "Nome Fantasia:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(120, MinimumLength = 5, ErrorMessage = "Campo {0} deve ter entre 5 e 120 caracteres")]
        public string TradingName { get; set; }

        [Display(Name = "CNPJ:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Cnpj { get; set; }

        [Display(Name = "Inscr. Estadual:")]
        [MaxLength(20, ErrorMessage = "Campo {0} deve ter no máximo 20 caracteres")]
        public string Ie { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Display(Name = "Logradouro:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo {0} deve ter entre 5 e 150 caracteres")]
        public string Address { get; set; }

        [Display(Name = "Número:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(10, ErrorMessage = "Campo {0} deve ter no máximo 10 caracteres")]
        public string Number { get; set; }

        [Display(Name = "Complemento:")]
        [MaxLength(20, ErrorMessage = "Campo {0} deve ter no máximo 20 caracteres")]
        public string Complement { get; set; }

        [Display(Name = "Bairro:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Campo {0} deve ter entre 3 e 80 caracteres")]
        public string Neighborhood { get; set; }

        [Display(Name = "CEP:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Cep { get; set; }

        [Display(Name = "Estado:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public BrazilianStates State { get; set; }

        [Display(Name = "Cidade:"), Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Campo {0} deve ter entre 3 e 100 caracteres")]
        public string City { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Data Cadastro:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CarrierPhoneNumberViewModel> CarrierPhoneNumbers { get; set; }

        public virtual ICollection<RatingViewModel> Ratings { get; set; }
    }
}
