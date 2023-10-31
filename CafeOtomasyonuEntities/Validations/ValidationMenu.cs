using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // Validation özelliklerini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonuEntities.Validations
{
    public class ValidationMenu:AbstractValidator<Menu>
    {
        public ValidationMenu()
        {
            RuleFor(x => x.MenuAdi).NotEmpty().WithMessage("Menü Adı Boş Geçilemez!!!");
            RuleFor(x => x.MenuAdi).MinimumLength(3).WithMessage("Menü Adı 30 Karakteri Geçemez!!!");
            RuleFor(x => x.MenuAdi).MaximumLength(30).WithMessage("Menü Adı 30 Karakteri Geçemez!!!");
        }
    }
}
