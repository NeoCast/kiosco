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
    class acusuario
    {

        private conexionbd conexion = new conexionbd();

        public void nuevoUsuario(string tipoUsuario, string usuario, string contrasena, string nombre)
        { 
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();


            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "sp_nuevoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.Parameters.AddWithValue("@nombre", nombre);
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
