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
    public class MalzemeTeminiDal
    {
        public List<MalzemeTemini> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.MalzemeTeminis.ToList();
            }
        }

        public void Add(MalzemeTemini malzemeTemini)
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                var entity = context.Entry(malzemeTemini);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
