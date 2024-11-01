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
    public class SiparisDetayDal
    {
        public List<SiparisDetay> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.SiparisDetays.ToList();
            }
        }

        public void Add(SiparisDetay siparisDetay)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisDetay);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(SiparisDetay siparisDetay)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisDetay);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(SiparisDetay siparisDetay)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(siparisDetay);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
