using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Eshop24.Domain.Validations
{
    public class UpperCaseAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            if (value is string text)
            {
                if (text.ToUpper() == text)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"The {validationContext.MemberName} field does not contain upper cases only.");
                }
            }

            throw new NotImplementedException($"The {nameof(UpperCaseAttribute)} cannot be used for the type: {value.GetType()}.");
        }
    }
}
