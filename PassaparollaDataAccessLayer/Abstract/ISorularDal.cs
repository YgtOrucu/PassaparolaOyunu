using PassaparollaEntityLayer.ConCreate;
using System.Collections.Generic;

namespace PassaparollaDataAccessLayer.Abstract
{
    public interface ISorularDal
    {
        void Insert(Sorular sorular);
        void Delete(Sorular sorular);
        void Update(Sorular sorular);
        List<Sorular> GetList();
  
    }
}
