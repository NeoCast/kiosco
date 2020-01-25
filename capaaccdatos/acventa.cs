using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    public class acventa
    {

        private conexionbd conexion = new conexionbd();

        public void nuevaVenta(double total, DateTime fecha)
        {


            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "nuevaVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

                conexion.cerrarcn();

            }
        }

        public void detalleVenta(int codProd, int cantidad, string descripcion, double total, DateTime fecha)
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "nuevoDetalleVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProd", codProd);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@descrip", descripcion);
                comando.Parameters.AddWithValue("@totalProd", total);
                comando.Parameters.AddWithValue("@ventaFecha", fecha);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

                conexion.cerrarcn();

            }

        }

    }
}
