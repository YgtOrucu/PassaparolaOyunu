using PassaparollaBusinenssLayer.Abstract;
using PassaparollaDataAccessLayer.Abstract;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaBusinenssLayer.Concreate
{
    public class SorularManager : ISorularService
    {
        private readonly ISorularDal _sorularDal;

        public SorularManager(ISorularDal sorularDal)
        {
            _sorularDal = sorularDal;
        }
        public void TDelete(Sorular sorular)
        {
            _sorularDal.Delete(sorular);
        }

        public List<Sorular> TGetList()
        {
            return _sorularDal.GetList();
        }

        public void TInsert(Sorular sorular)
        {
            _sorularDal.Insert(sorular);
        }

        public void TUpdate(Sorular sorular)
        {
            _sorularDal.Update(sorular);
        }
    }
}
