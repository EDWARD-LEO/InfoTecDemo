using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Producto
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            return acceso.getDataFrom("spu_productos_listar_todos");
        }

        public DataTable buscarCodigoBarra(string codBarra)
        {
            return acceso.getDataWithCondition("spu_productos_buscar_codbarra", "@codbarra", codBarra);
        }
    }
}
