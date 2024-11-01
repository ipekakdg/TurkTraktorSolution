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
    public class TestlerDal
    {
        public List<Testler> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Testlers.ToList();
            }
        }

        public void Add(Testler testler)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(testler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
