using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Satislar
    {
        [Key]
        public int SatisID { get; set; }
        public int MusteriID { get; set; }
        public int UrunID { get; set; }
        public int SaticiID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
