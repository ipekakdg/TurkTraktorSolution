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
    public class ImalatlarDal
    {
        public List<Imalatlar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Imalatlars.ToList();
            }
        }

        public void Add(Imalatlar imalatlar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(imalatlar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
