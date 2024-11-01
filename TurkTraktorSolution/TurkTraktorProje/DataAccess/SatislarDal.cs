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
    public class SatislarDal
    {
        public List<Satislar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Satislars.ToList();
            }
        }

        public void Add(Satislar satislar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(satislar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Satislar satislar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(satislar);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Satislar satislar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(satislar);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
