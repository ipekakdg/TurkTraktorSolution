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
    public class KategorilerDal
    {
        public List<Kategoriler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Kategorilers.ToList();
            }
        }

        public void Add(Kategoriler kategoriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(kategoriler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Kategoriler kategoriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(kategoriler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Kategoriler kategoriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(kategoriler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
