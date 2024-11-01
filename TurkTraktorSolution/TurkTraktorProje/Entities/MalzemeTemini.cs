using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class MalzemeTemini
    {
        [Key]
        public int MalzemeID { get; set; }
        public string MalzemeCesidi { get; set; }
        public int UrunID { get; set; }
    }
}
