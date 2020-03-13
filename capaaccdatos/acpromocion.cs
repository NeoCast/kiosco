using System;
using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    public class acpromocion
    {
        private conexionbd conexion = new conexionbd();

        public void nuevaPromo(string descripcion, double total, int activa)
        {



            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "nuevaPromo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@activa", activa);
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

        public DataTable buscarPromos()
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "buscarPromos";
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
        public DataTable masPromos()
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "buscarDetallePromocion";
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

        public void eliminarPromocion(int codPromo)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "eliminarPromocion";
                comando.Parameters.AddWithValue("codPromo", codPromo);
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
