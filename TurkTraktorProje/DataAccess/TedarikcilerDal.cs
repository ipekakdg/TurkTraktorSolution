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
    public class TedarikcilerDal
    {
        public List<Tedarikciler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Tedarikcilers.ToList();
            }
        }

        public void Add(Tedarikciler tedarikciler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(tedarikciler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Tedarikciler tedarikciler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(tedarikciler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Tedarikciler tedarikciler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(tedarikciler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
