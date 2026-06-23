using PassaparollaEntityLayer.ConCreate;
using System.Collections.Generic;

namespace PassaparollaDataAccessLayer.Abstract
{
    public interface IAdminDal
    {
        Admin GetAdminUsers(string kullanıcıadı, string sıfre);
        void Insert(Sorular sorular); 
        void Delete(int ıd); 
        void Update(Sorular sorular); 
        List<Sorular> GetList();
        List<Sorular> GetDurumList(bool durum); 
        Sorular GetByID(int ıd);
        List<Sorular> DurumandHarfeGöreListe(string harf, bool durum);
    }
}
