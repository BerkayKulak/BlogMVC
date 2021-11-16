using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş geçemezsiniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesajı boş geçemezsiniz");
        }
    }
}
