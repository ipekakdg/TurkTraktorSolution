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
    public class MontajlarDal
    {
        public List<Montajlar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Montajlars.ToList();
            }
        }

        public void Add(Montajlar montajlar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(montajlar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
