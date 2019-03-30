using Application.Entity.Musteri;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri
{
   public class MusteriValidation:AbstractValidator<Musteri>
    {
        public MusteriValidation()
        {
            RuleFor(m => m.Ad).NotEmpty().WithMessage("Müşterinin Adı girilmesi gerekir");
            RuleFor(m => m.Soyad).NotEmpty().WithMessage("Müşterinin Soyadı girilmesi gerekir");
          
        }
    }
}
