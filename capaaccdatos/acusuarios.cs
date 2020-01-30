using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capasoporte.Cache;
using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    public class acusuarios
    {
        private conexionbd conexion = new conexionbd();


        public bool login(string usuario, string contrasena)
        {

            using (var comando = new SqlCommand())
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "select *from usuarios where usuario=@usuario and contrasena=@contrasena";
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.CommandType = CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        uCache.idUsuario = reader.GetInt32(0);
                        uCache.nombre = reader.GetString(3);
                        uCache.cargo = reader.GetString(4);
                    }
                    return true;
                }
                else
                    return false;
            }

        }
        public void AnyMethod()
        {
            //Seguridad y permisos
            if (uCache.cargo == cargos.administrador)
            {
                // codigo
            }
            if (uCache.cargo == cargos.empleado)
            {
                // codigo
            }
        }

        public void nuevoUsu(string usuario, string contrasena, string nombre, string cargo)
        {
            SqlCommand comando = new SqlCommand();
            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "altausuarios";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cargo", cargo);
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
        public DataTable todosUsu()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "todosUsu";
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

        public void eliminarUsu(int codUsu)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "eliminarUsu";
                comando.Parameters.AddWithValue("idUsuario", codUsu);
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