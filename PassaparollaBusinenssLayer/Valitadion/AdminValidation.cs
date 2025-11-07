using FluentValidation;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaBusinenssLayer.Valitadion
{
    public class AdminValidation : AbstractValidator<Admin>
    {
        public AdminValidation()
        {
            // [^DEGER] PARANTEZ İÇİN DE ^ varsa oraya yazılan değer ıstenılen yerde olamaz demek oluyor
            //.Matches("^[^0-9]*$").WithMessage("Kullanıcı Adı rakam içeremez");



            // ^[DEGER] PARANTEZ İÇİN DE ^ yoksa oraya yazılan değer ıstenılen yerde olması gerek demek oluyor
            //+ → en az bir karakter olmalı, birden fazla olabilir.
            //^ ...$ → baştan sona sadece bunlar olmalı.

            //.Matches("^[a-zA-ZçÇğĞıİöÖşŞüÜ]+$").WithMessage("Kullanıcı Adı sadece harf içerebilir");


            RuleFor(x => x.KullanıcıAdı)
                .NotEmpty().WithMessage("Kullanıcı Adı Boş bırakılamaz")
                .MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 Karakterden oluşmalıdır")
                .MaximumLength(15).WithMessage("Kullanıcı Adı en fazla 15 Karakterden oluşmalıdır");
            RuleFor(x => x.Sıfre)
               .NotEmpty().WithMessage("Sıfre Boş bırakılamaz")
               .MaximumLength(5).WithMessage("Sıfre en fazla 5 Karakterden oluşmalıdır");
        }
    }

}
