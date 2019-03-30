using Application.Entity.Urun;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.urun
{
   public class UrunValidation: AbstractValidator<Urun>
    {
        public UrunValidation()
        {
            RuleFor(u => u.Ad).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(u => u.Adet).NotEmpty().WithMessage("Adet sayısı alanı boş geçilemez");
            RuleFor(u => u.Fiyat).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            //RuleFor(u => u.ID).NotEmpty().WithMessage("ID alanı boş geçilemez");
            RuleFor(u => u.MusteriID).NotEmpty().WithMessage("Ürünü hangi müşteri alıyor bilmemiz gerekir");
            RuleFor(u => u.BarkodID).NotEmpty().WithMessage("Ürünün Barkod ID'si girilmesi gerekilir");
        }
    }
}
