using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int StokMiktari { get; set; }
        public int KategoriID { get; set; }
        public int SatisFiyati { get; set; }
        public int TedarikciID { get; set; }
    }
}
