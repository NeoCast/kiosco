using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace capaaccdatos
{
     public class acdetallePromo
    {
        private conexionbd conexion = new conexionbd();

        public void nuevoDetallePromo(Int32 codPromo, Int32 codProd, string descrProd, double totalProd, Int32 cantidad)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "nuevaPromo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codPromo", codPromo);
                comando.Parameters.AddWithValue("@codProd", codProd);
                comando.Parameters.AddWithValue("@descripcion", descrProd);
                comando.Parameters.AddWithValue("@totalProd", totalProd);
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
