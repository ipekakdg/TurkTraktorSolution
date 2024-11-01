using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTraktorProje.Context;
using System.Data.Entity;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje.DataAccess
{
    public class DepolarDal
    {
        public List<Depolar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Depolars.ToList();
            }
        }

        public void Add(Depolar depolar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(depolar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Depolar depolar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(depolar);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Depolar depolar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(depolar);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
