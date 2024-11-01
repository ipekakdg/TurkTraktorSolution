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
    public class TasarimDal
    {
        public List<Tasarim> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Tasarims.ToList();
            }
        }

        public void Add(Tasarim tasarim)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(tasarim);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
