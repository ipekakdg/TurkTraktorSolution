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
    public class PersonellerDal
    {
        public List<Personeller> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Personellers.ToList();
            }
        }

        public void Add(Personeller personeller)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(personeller);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Personeller personeller)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(personeller);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Personeller personeller)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(personeller);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
