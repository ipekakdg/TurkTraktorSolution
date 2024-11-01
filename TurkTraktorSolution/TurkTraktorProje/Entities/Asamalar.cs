using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Asamalar
    {
        [Key]
        public int AsamaID { get; set; }
        public string AsamaAdi { get; set; }
    }
}
