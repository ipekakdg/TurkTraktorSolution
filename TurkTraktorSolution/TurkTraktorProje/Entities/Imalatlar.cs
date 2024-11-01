using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Imalatlar
    {
        [Key]
        public int ImalatID { get; set; }
        public string ParcaUretimi { get; set; }
        public string Parcalar { get; set; }
        public int UrunID { get; set; }
    }
}
