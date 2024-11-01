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
    public class SaticilarDal
    {
        public List<Saticilar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Saticilars.ToList();
            }
        }

        public void Add(Saticilar saticilar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(saticilar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Saticilar saticilar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(saticilar);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Saticilar saticilar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(saticilar);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
