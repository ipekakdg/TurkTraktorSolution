using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Siparisler
    {
        [Key]
        public int SiparisID { get; set; }
        public int MusteriID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
