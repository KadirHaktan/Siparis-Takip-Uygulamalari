using Application.Entity.Musteri;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri
{
   public class AdresValidation:AbstractValidator<Adres>
    {
        public AdresValidation()
        {
            RuleFor(a => a.MusteriID).NotEmpty().WithMessage("Musteri ID girilmesi gerekir");
            RuleFor(a => a.TamAdres).MaximumLength(125).NotEmpty().WithMessage("Tam Adres uzunluğu en fazla 125 karakter olacak ve boş geçilmemesi gerekir");
        }
    }
}
