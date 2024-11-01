using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Sevkiyatlar
    {
        [Key]
        public int SevkiyatID { get; set; }
        public string AmbalajDurumu { get; set; }
        public string SevkiyatYeri { get; set; }
        public int UrunID { get; set; }
    }
}
