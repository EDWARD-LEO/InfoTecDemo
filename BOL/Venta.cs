using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;
using ENTITIES;

namespace BOL
{
    public class Venta
    {
        DBAccess acceso = new DBAccess();

        /// <summary>
        /// Si el valor devuelto es -1 significa que no se concretó el proceso, en cambio si el valor es
        /// mayor a 0, consideraremos este dato como el ID de la venta generada
        /// </summary>
        /// <returns></returns>
        public int registrar(EVenta entidad)
        {
            SqlCommand comando = new SqlCommand("spu_venta_registrar", acceso.getConexion());
            int idobtenido;

            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;

                //El primer parámetro es OUTPUT, por lo que se debe construir como OBJETO
                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@idventa";
                idventa.DbType = DbType.Int32;
                idventa.Direction = ParameterDirection.Output;

                //Pasamos el parámetro de salida
                comando.Parameters.Add(idventa);

                //Pasamos los parámetros de entrada
                comando.Parameters.AddWithValue("@tipocomprobante", entidad.tipocomprobante);
                comando.Parameters.AddWithValue("@numcomprobante", entidad.numcomprobante);
                comando.Parameters.AddWithValue("@idcliente", entidad.idcliente);
                comando.Parameters.AddWithValue("tipopago", entidad.tipopago);

                comando.ExecuteNonQuery();

                //Retornamos el idgenerado convirtiéndolo a entero
                idobtenido = Convert.ToInt32(idventa.Value);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                idobtenido = -1;
            }
            finally
            {
                acceso.desconectar();
            }

            return idobtenido;
        }

        public bool registrarDetalle(EDetalleventa entidad)
        {
            bool guardadoCorrectamente = false;
            SqlCommand comando = new SqlCommand("spu_detventa_registrar", acceso.getConexion());
            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idventa", entidad.idventa);
                comando.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                comando.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                comando.Parameters.AddWithValue("@precioventa", entidad.precioventa);

                if (comando.ExecuteNonQuery() > 0)
                {
                    guardadoCorrectamente = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                guardadoCorrectamente = false;
            }
            finally
            {
                acceso.desconectar();
            }

            return guardadoCorrectamente;
        }
    }
}
