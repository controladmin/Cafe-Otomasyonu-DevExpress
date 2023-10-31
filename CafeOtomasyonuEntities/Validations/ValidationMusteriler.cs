using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // AbstractValidator ifadesini kullanabilmek için bu kütüphaneyi kullandık

namespace CafeOtomasyonuEntities.Validations
{
    public class ValidationMusteriler:AbstractValidator<Musteriler>
    {
        public ValidationMusteriler()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez!!!");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez!!!");
            RuleFor(p => p.Adres).NotEmpty().WithMessage("Adres Alanı Boş Geçilmez!!!");
        }
    }
}
