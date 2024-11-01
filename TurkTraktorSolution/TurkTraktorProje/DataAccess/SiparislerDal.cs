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
    public class SiparislerDal
    {
        public List<Siparisler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Siparislers.ToList();
            }
        }

        public void Add(Siparisler siparisler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Siparisler siparisler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Siparisler siparisler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
