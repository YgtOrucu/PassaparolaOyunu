using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaDataAccessLayer.Abstract
{
    public interface ISorularDal
    {
        void Insert(Sorular sorular); //Ekleme
        void Delete(Sorular sorular); //Silme
        void Update(Sorular sorular); //Güncelleme
        List<Sorular> GetList();//Listeleme
  
    }
}
