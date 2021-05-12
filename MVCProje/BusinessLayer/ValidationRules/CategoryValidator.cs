using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("KATEGORİ ADINI BOŞ GEÇEMEZSİNİZ");
            RuleFor(X => X.CategoryDescription).NotEmpty().WithMessage("AÇIKLAMAYI BOŞ GEÇEMEZSİNİZ");
            RuleFor(X => X.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayın.");
        }
    }
}
