using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
    }
}
