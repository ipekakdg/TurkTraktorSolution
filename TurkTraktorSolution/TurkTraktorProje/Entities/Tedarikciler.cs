using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Tedarikciler
    {
        [Key]
        public int TedarikciID { get; set; }
        public string TedarikciAdi { get; set; }
        public int Telefon { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
