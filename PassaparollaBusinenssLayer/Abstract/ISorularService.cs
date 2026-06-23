using PassaparollaEntityLayer.ConCreate;
using System.Collections.Generic;

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
