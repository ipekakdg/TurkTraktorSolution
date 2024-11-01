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
    public class AsamalarDal
    {
        public List<Asamalar> GetAll()
        {
            using (TurkTraktorContext context = new TurkTraktorContext())
            {
                return context.Asamalars.ToList();
            }
        }

    }
}
