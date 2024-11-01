using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class IadeHareketleri
    {
        [Key]
        public int IadeID { get; set; }
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public DateTime IadeTarihi { get; set; }
    }
}
