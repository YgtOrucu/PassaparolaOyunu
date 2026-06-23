using PassaparollaEntityLayer.ConCreate;
using System.Collections.Generic;

namespace PassaparollaBusinenssLayer.Abstract
{
    public interface IAdminService
    {
        Admin TGetAdminUsers(string kullanıcıadı, string sıfre);

        void TInsert(Sorular sorular); 
        void TDelete(int ıd); 
        void TUpdate(Sorular sorular); 
        List<Sorular> TGetList();
        List<Sorular> TGetDurumList(bool durum);
        Sorular TGetByID(int ıd);
        List<Sorular> TDurumandHarfeGöreListe(string harf, bool durum);
    }
}
