using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Tasarim
    {
        [Key]
        public int TasarimID { get; set; }
        public string Ozellikler { get; set; }
        public int Boyut { get; set; }
        public int Guc { get; set; }
        public string TeknikDetay { get; set; }
        public int UrunID { get; set; }
    }
}
