using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class StokHareketleri
    {
        [Key]
        public int HareketID { get; set; }
        public int UrunID { get; set; }
        public int DepoID { get; set; }
        public int Miktar { get; set; }
        public DateTime HareketTarihi { get; set; }
    }
}
