using System;
using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    public class acdetallePromo
    {
        private conexionbd conexion = new conexionbd();

        public void nuevoDetallePromo( Int32 codProd, string descrProd, Int32 cantidad)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "sp_nuevoDetallePromo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProd", codProd);
                comando.Parameters.AddWithValue("@descrProd", descrProd);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
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
