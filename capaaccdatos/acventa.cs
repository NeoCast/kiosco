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

        public string detalleVenta(int codProd, string tipoProd, int codPromo,int cantidad, string descripcion, double total, DateTime fecha)
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            string res_consulta;
            try
            {


                comando.Connection = conexion.abrircn();
                comando.CommandText = "nuevoDetalleVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProd", codProd);
                comando.Parameters.AddWithValue("@tipoProd", tipoProd);
                comando.Parameters.AddWithValue("@codPromo", codPromo);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@totalProd", total);
                comando.Parameters.AddWithValue("@descrip", descripcion);
                comando.Parameters.AddWithValue("@ventaFecha", fecha);
                comando.ExecuteNonQuery();
                res_consulta = "Se ha vendido exitosamente";
            }
            catch (Exception ex)
            {

                throw ex;
                res_consulta = "No se ha podido realizar la venta";
            }
            finally
            {

                conexion.cerrarcn();

            }

            return res_consulta;

        }

        public DataTable buscarDetalleVta(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "buscarDetalleVta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                reader = comando.ExecuteReader();
                tabla.Load(reader);

                return tabla;
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

        public DataTable todoDetalleVta()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "todosDetallesVta";
                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();
                tabla.Load(reader);

                return tabla;
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

        public DataTable buscarPorTipoProducto(string tProducto)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            try
            {
                //
                comando.Connection = conexion.abrircn();
                comando.CommandText = "buscarDetallePorTprod";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tProducto", tProducto);
                reader = comando.ExecuteReader();
                tabla.Load(reader);
                return tabla;
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
