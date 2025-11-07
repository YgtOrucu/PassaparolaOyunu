using FluentValidation;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaBusinenssLayer.Valitadion
{
    public class SorularValidation : AbstractValidator<Sorular>
    {
        public SorularValidation()
        {   
            RuleFor(x=>x.Soru)
                .NotNull().WithMessage("Soru Alanı Boş Bırakılamaz")
                .MinimumLength(15).WithMessage("Soru Alanı minimum 15 karakterden oluşmalıdır.")
                .Matches("^[^0-9]*$").WithMessage("Soru alanı rakam içeremez.Sadece harflerden oluşabilir");
            RuleFor(x => x.Harf)
                .NotNull().WithMessage("Harf Alanı Boş Bırakılamaz")
                .MinimumLength(1).WithMessage("Harf Alanı minimum 1 karakterden oluşmalıdır.")
                .Matches("^[^0-9]*$").WithMessage("Harf alanı rakam içeremez.Sadece harflerden oluşabilir")
                .Matches("^[A-ZÇĞİÖŞÜ]$").WithMessage("Harf Alanı yalnızca büyük harflerden oluşmalıdır");
            RuleFor(x => x.Cevap)
                .NotNull().WithMessage("Cevap Alanı Boş Bırakılamaz");
        }
    }
}
