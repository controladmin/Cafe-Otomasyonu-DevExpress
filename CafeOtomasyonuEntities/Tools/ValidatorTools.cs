using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Validator özelliğini kullanabilmek için bu kütüphaneyi ekledik
using CafeOtomasyonuEntities.Interface;
using FluentValidation; // IValidator özelliğin kullanabilmek için bu kütüphaneyi ekledik
using System.Windows.Forms;

namespace CafeOtomasyonuEntities.Tools
{
   public class ValidatorTools
    {
        public static bool Validates(IValidator validator,IEntity entity)
        {
            bool result = true;
            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var ValidationResult = validator.Validate(context);

            if(!ValidationResult.IsValid)
            {
                string Message = "";
                foreach(var error in ValidationResult.Errors)
                {
                    Message += error.ErrorMessage + "\n";
                }
                MessageBox.Show(Message);
                result=false;
            }
            return result;
        }
    }
}
