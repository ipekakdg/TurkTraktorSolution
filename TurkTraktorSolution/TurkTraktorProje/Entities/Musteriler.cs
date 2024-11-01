using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Musteriler
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public int Telefon { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
