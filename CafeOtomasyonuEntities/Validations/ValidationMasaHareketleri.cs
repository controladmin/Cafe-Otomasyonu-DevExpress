using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // Validation özelliklerini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonuEntities.Validations
{
    public class ValidationMasaHareketleri:AbstractValidator<MasaHareketleri>
    {
        public ValidationMasaHareketleri()
        {
            RuleFor(x => x.SatisKodu).NotEmpty().WithMessage("Satış Kodu Alanı Boş Geçilmez!!!");
           // RuleFor(x => x.SatisKodu).Length(12).WithMessage("Satış Kodu 12 Karekteri Geçemez!!!");
            RuleFor(x => x.Miktar).NotEmpty().WithMessage("Miktar Alanı Boş Geçilemez!!!");
            RuleFor(x => x.Miktar).GreaterThan(0).WithMessage("Miktar 0'dan Büyük Olmalıdır!!!");
            RuleFor(x => x.BirimFiyat).NotEmpty().WithMessage("Birim Fiyatı Boş Geçilemez!!!");
            RuleFor(x => x.BirimFiyat).LessThanOrEqualTo(1000000).WithMessage("Birim Fiyat 1000000'dan Büyük Olamaz!!!");
        }
    }
}
