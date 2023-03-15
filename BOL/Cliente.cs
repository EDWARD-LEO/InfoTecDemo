using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Cliente
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            return acceso.getDataFrom("spu_clientes_listar_todos");
        }
    }
}
