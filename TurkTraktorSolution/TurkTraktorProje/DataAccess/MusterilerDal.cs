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
    public class MusterilerDal
    {
        public List<Musteriler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Musterilers.ToList();
            }
        }

        public void Add(Musteriler musteriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(musteriler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Musteriler musteriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(musteriler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Musteriler musteriler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(musteriler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
