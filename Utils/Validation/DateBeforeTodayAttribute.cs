using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_WebApp.Utils.Validation
{
    public class DateBeforeTodayAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = value as DateTime?;
            if (date is null)
            {
                return new ValidationResult("Type is not 'DateTime'.");
            }
            else
            {
                if (date.Value.CompareTo(DateTime.Now) <= 0)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"Data trebuie sa fie inainte de data de azi.");
                }
            }
        }
    }
}
