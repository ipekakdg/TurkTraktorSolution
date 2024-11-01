using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkTraktorProje.Entities
{
    public class Testler
    {
        [Key]
        public int TestID { get; set; }
        public string TestCesidi { get; set; }
        public int UrunID { get; set; }

    }
}
