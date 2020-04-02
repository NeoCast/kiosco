using System;
using System.Data;
using System.Data.SqlClient;
using capaentidades;

namespace capaaccdatos
{
    public class acdetallePromo
    {
        private conexionbd conexion = new conexionbd();

        public void nuevoDetallePromo(detallePromocion dtPromo)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "sp_nuevoDetallePromo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProd", dtPromo.codProd);
                comando.Parameters.AddWithValue("@descrProd", dtPromo.descriProd);
                comando.Parameters.AddWithValue("@cantidad", dtPromo.cantidad);
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
