using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaBusinenssLayer.Abstract
{
    public interface ISorularService
    {
        void TInsert(Sorular sorular);
        void TDelete(Sorular sorular);
        void TUpdate(Sorular sorular);
        List<Sorular> TGetList();
    }
}
