using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Depolar
    {
        [Key]
        public int DepoID { get; set; }
        public string DepoAdi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
