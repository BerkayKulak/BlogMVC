using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adı Boş geçemezsiniz");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar Başlık Adı Boş geçemezsiniz");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazar Görseli Boş geçemezsiniz");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Yazar Hakkında Boş geçemezsiniz");
           
        }
    }
}
