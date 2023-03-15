using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EVenta
    {
        public int idventa { get; }
        public char tipocomprobante { get; set; }
        public int numcomprobante { get; set; }
        public int idcliente { get; set; }
        public string tipopago { get; set; }
    }
}
