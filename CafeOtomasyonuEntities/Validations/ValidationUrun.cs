using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // Validation özelliklerini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonuEntities.Validations
{
   public class ValidationUrun:AbstractValidator<Urun>
    {
        public ValidationUrun()
        {
            RuleFor(x => x.UrunKodu).NotEmpty().WithMessage("Ürün Kdu Alanı Boş Geçilemez!!!");
            RuleFor(x => x.UrunAdi).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez!!!");
            RuleFor(x => x.BirimFiyat1).NotEmpty().WithMessage("Birim Fiyat 1 Alanı Boş Geçilemez!!!");
            RuleFor(x => x.BirimFiyat2).NotEmpty().WithMessage("Birim Fiyat 2 Alanı Boş Geçilemez!!!");
            RuleFor(x => x.BirimFiyat3).NotEmpty().WithMessage("Birim Fiyat 3 Alanı Boş Geçilemez!!!");
        }
    }
}
