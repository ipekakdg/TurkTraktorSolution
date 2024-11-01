using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTraktorProje.Context;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje.DataAccess
{
    public class UrunlerDal
    {
        public List<Urunler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Urunlers.ToList();
            }
        }

        public void Add(Urunler urunler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(urunler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Urunler urunler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(urunler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Urunler urunler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(urunler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
