using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Boyamalar
    {
        [Key]
        public int BoyamaID { get; set; }
        public string BoyamaTuru { get; set; }
        public int UrunID { get; set; }
    }
}
