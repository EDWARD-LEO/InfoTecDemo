using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EDetalleventa
    {
        public int idventa { get; set; }
        public int idproducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioventa { get; set; }
    }
}
