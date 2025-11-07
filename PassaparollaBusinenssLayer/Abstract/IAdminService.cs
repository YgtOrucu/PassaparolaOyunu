using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaBusinenssLayer.Abstract
{
    public interface IAdminService
    {
        Admin TGetAdminUsers(string kullanıcıadı, string sıfre);

        void TInsert(Sorular sorular); //Soru Ekleme
        void TDelete(int ıd); //Soru Silme
        void TUpdate(Sorular sorular); //Soru Güncelleme
        List<Sorular> TGetList();//Soru Listeleme
        List<Sorular> TGetDurumList(bool durum); ///Duruma göre Listeleme
        Sorular TGetByID(int ıd);
        List<Sorular> TDurumandHarfeGöreListe(string harf, bool durum);
    }
}
