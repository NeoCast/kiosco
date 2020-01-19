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
     public class acpromocion
    {
        private conexionbd conexion = new conexionbd();

        public void nuevaPromo(string descripcion, double total, bool activa)
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

    }
}
