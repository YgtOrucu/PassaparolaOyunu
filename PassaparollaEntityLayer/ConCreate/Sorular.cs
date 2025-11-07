using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaEntityLayer.ConCreate
{
    public class Sorular
    {
        public int ID { get; set; }
        public string Harf { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
        public bool Durum { get; set; }
    }
}
