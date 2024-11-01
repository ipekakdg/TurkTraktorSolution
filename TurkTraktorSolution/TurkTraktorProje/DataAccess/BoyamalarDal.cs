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
    public class BoyamalarDal
    {
        public List<Boyamalar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Boyamalars.ToList();
            }
        }

        public void Add(Boyamalar boyamalar)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(boyamalar);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
