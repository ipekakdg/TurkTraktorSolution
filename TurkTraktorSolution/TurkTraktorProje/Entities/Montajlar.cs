using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Montajlar
    {
        [Key]
        public int MontajID { get; set; }
        public string MontajYeri { get; set; }
        public int UrunID { get; set; }
    }
}
