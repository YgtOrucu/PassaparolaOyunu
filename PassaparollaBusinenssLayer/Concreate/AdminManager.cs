using FluentValidation;
using PassaparollaBusinenssLayer.Abstract;
using PassaparollaBusinenssLayer.Valitadion;
using PassaparollaDataAccessLayer.Abstract;
using PassaparollaEntityLayer.ConCreate;
using System.Collections.Generic;

namespace PassaparollaBusinenssLayer.Concreate
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        private readonly AdminValidation _validationRules;
        private readonly SorularValidation _validationRulesSorular;

        public AdminManager(IAdminDal adminDal, AdminValidation validationRules, SorularValidation validationRulesSorular)
        {
            _adminDal = adminDal;
            _validationRules = validationRules;
            _validationRulesSorular = validationRulesSorular;
        }

        public List<Sorular> TDurumandHarfeGöreListe(string harf, bool durum)
        {
            return _adminDal.DurumandHarfeGöreListe(harf, durum);
        }

        public void TDelete(int ıd)
        {
            _adminDal.Delete(ıd);
        }

        public Admin TGetAdminUsers(string kullanıcıadı, string sıfre)
        {

            var admin = new Admin
            {
                KullanıcıAdı = kullanıcıadı,
                Sıfre = sıfre
            };

            var result = _validationRules.Validate(admin);

            if (!result.IsValid) throw new ValidationException(result.Errors);
            return _adminDal.GetAdminUsers(kullanıcıadı, sıfre);

        }

        public Sorular TGetByID(int ıd)
        {
            return _adminDal.GetByID(ıd);
        }

        public List<Sorular> TGetDurumList(bool durum)
        {
            return _adminDal.GetDurumList(durum);
        }

        public List<Sorular> TGetList()
        {
            return _adminDal.GetList();
        }

        public void TInsert(Sorular sorular)
        {
            var soru = new Sorular
            {
                Soru = sorular.Soru,
                Harf = sorular.Harf,
                Cevap = sorular.Cevap,
                Durum = true
            };

            var result = _validationRulesSorular.Validate(soru);

            if (!result.IsValid) throw new ValidationException(result.Errors);

            _adminDal.Insert(sorular);
        }

        public void TUpdate(Sorular sorular)
        {
            _adminDal.Update(sorular);
        }
    }
}
