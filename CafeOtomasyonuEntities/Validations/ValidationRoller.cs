using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using FluentValidation; // Validation özelliklerini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonuEntities.Validations
{
    public class ValidationRoller:AbstractValidator<Roller>
    {
        public ValidationRoller()
        {

        }
    }
}
