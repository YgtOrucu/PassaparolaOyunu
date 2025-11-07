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
    public class AdminRepository : IAdminDal
    {
        PassaparollaContext _context = new PassaparollaContext();
        public Admin GetAdminUsers(string kullanıcıadı, string sıfre)
        {
            var values = _context.Admins.FirstOrDefault(x => x.KullanıcıAdı == kullanıcıadı && x.Sıfre == sıfre);
            return values;
        }

        public void Delete(int ıd)
        {
            var values = _context.Sorulars.Find(ıd);
            values.Durum = false;
            _context.SaveChanges();
        }

        public List<Sorular> GetDurumList(bool durum)
        {
            return _context.Sorulars.Where(x => x.Durum == durum).ToList();
        }

        public List<Sorular> GetList()
        {
            return _context.Sorulars.ToList();
        }

        public void Insert(Sorular sorular)
        {
            _context.Sorulars.Add(sorular);
            _context.SaveChanges();
        }

        public void Update(Sorular sorular)
        {
            var updated = _context.Entry(sorular);
            updated.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Sorular GetByID(int ıd)
        {
            return _context.Sorulars.Find(ıd);
        }

        public List<Sorular> DurumandHarfeGöreListe(string harf, bool durum)
        {
            return _context.Sorulars.Where(x => x.Harf == harf && x.Durum == durum).ToList();
        }
    }
}
