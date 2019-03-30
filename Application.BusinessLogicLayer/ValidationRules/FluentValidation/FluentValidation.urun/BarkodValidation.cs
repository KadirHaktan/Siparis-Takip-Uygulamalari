using Application.Entity.Urun;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.urun
{
    public class BarkodValidation:AbstractValidator<Barkod>
    {
        public BarkodValidation()
        {
            RuleFor(b => b.BarkodNo).GreaterThanOrEqualTo(4).NotEmpty().WithMessage("Barkod Numarası 4 karakterli olmalı ve boş geçilmemeli");
            //RuleFor(b => b.ID).NotEmpty().WithMessage("ID alanı boş geçilemez");
            RuleFor(b => b.UrunID).NotEmpty().WithMessage("Urun ID'si boş geçilemez");
        }
    }
}
