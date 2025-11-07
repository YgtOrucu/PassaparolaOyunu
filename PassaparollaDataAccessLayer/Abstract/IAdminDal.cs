using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaDataAccessLayer.Abstract
{
    public interface IAdminDal
    {
        Admin GetAdminUsers(string kullanıcıadı, string sıfre); //Kullanıcıadı  sıfreye göre admınsayfasına giriş için
        void Insert(Sorular sorular); //Soru Ekleme
        void Delete(int ıd); //Soru Silme
        void Update(Sorular sorular); //Soru Güncelleme
        List<Sorular> GetList();//Soru Listeleme
        List<Sorular> GetDurumList(bool durum); ///Duruma göre Listeleme
        Sorular GetByID(int ıd);
        List<Sorular> DurumandHarfeGöreListe(string harf, bool durum);
    }
}
