using PassaparollaDataAccessLayer.Abstract;
using PassaparollaDataAccessLayer.Context;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaDataAccessLayer.Repository
{
    public class SorularRepository : ISorularDal
    {
        PassaparollaContext _context = new PassaparollaContext();
        private readonly DbSet<Sorular> _object;

        public SorularRepository()
        {
            _object = _context.Set<Sorular>();
        }
        public void Delete(Sorular sorular)
        {
            var deleted = _context.Entry(sorular);
            deleted.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<Sorular> GetList()
        {
            return _object.ToList();
        }
        public void Insert(Sorular sorular)
        {
            var added = _context.Entry(sorular);
            added.State = EntityState.Added;
            _context.SaveChanges();
        }
        public void Update(Sorular sorular)
        {
            var updated = _context.Entry(sorular);
            updated.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
