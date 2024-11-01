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
    public class IadeHareketleriDal
    {
          public List<IadeHareketleri> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.IadeHareketleris.ToList();
            }
        }

        public void Add(IadeHareketleri iadeHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(iadeHareketleri);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(IadeHareketleri iadeHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(iadeHareketleri);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(IadeHareketleri iadeHareketleri)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(iadeHareketleri);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
