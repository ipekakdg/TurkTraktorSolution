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
    public class SevkiyatlarDal
    {
        public List<Sevkiyatlar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Sevkiyatlars.ToList();
            }
        }

        public void Add(Sevkiyatlar sevkiyatlar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(sevkiyatlar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
