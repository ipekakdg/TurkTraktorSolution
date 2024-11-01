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
    public class StokHareketleriDal
    {
        public List<StokHareketleri> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.StokHareketleris.ToList();
            }
        }

        public void Add(StokHareketleri stokHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(stokHareketleri);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(StokHareketleri stokHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(stokHareketleri);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(StokHareketleri stokHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(stokHareketleri);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
