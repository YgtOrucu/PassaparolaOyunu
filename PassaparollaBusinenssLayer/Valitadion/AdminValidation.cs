using FluentValidation;
using PassaparollaEntityLayer.ConCreate;


namespace PassaparollaBusinenssLayer.Valitadion
{
    public class AdminValidation : AbstractValidator<Admin>
    {
        public AdminValidation()
        {
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
