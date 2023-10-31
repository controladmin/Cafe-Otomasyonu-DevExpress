using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // Validation özelliklerini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonuEntities.Validations
{
    public class ValidationKullanicilar:AbstractValidator<Kullanici>
    {
        public ValidationKullanicilar()
        {
            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez!!!");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez!!!");
            RuleFor(x => x.KullaniciAdi).MinimumLength(5).WithMessage("Kullanıcı Adı 5 Karakterden Az Olamaz!!!");
            RuleFor(x => x.KullaniciAdi).MaximumLength(30).WithMessage("Kullanıcı Adı 30 Karakterden Fazla Olamaz!!!");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Parola Alanı Boş Geçilemez!!!");
            RuleFor(x => x.Sifre).MinimumLength(6).WithMessage("Parola Alanı 6 Karakterden Az Olamaz!!!");
            RuleFor(x => x.Sifre).MaximumLength(20).WithMessage("Parola Alanı 20 Karakterden Fazla Olamaz!!!");
            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez!!!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez!!!");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Yanlış Email Formatı!!!");
        }
    }
}
