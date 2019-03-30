using Application.Entity.Musteri;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri
{
    class TelefonValidation:AbstractValidator<Telefon>
    {
        public TelefonValidation()
        {
            RuleFor(t => t.TelefonNo).GreaterThanOrEqualTo(11).NotEmpty().WithMessage("Telefon Numarası 11 karakterli olmalıdır ve boş geçilemez");
            RuleFor(t => t.MusteriID).NotEmpty().WithMessage("Musteri ID'si yazılması gerekilir");
        }
    }
}
