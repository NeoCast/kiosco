using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using capaentidades;


namespace capaaccdatos
{
     public class acSerial
    {

        private conexionbd conexion = new conexionbd();

        public psver consultaIsInstall()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            psver serial = new psver();
            try
            {
               
                comando.Connection = conexion.abrircn();
                comando.CommandText = "select top 1 * from psver order by 1";
                comando.CommandType = CommandType.Text;
                reader = comando.ExecuteReader();
                //serial = comando.ExecuteScalar();
                //while (reader.Read())
                //{

                //}
                tabla.Load(reader);
                serial.idP = Convert.ToInt32(tabla.Rows[0][0]);
                serial.descripcion = Convert.ToString(tabla.Rows[0][1]);
                serial.num_i = Convert.ToInt32(tabla.Rows[0][2]);
                serial.dFecha = Convert.ToDateTime(tabla.Rows[0][3]);
                serial.hFecha = Convert.ToDateTime(tabla.Rows[0][4]);
                serial.valStr = Convert.ToString(tabla.Rows[0][5]);
                serial.pvez = Convert.ToInt32(tabla.Rows[0][6]);
                return serial;
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

        public void modificarParametro(psver inParametro)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            parametro serial = new parametro();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "updatePsver";
                comando.Parameters.AddWithValue("@idP", inParametro.idP);
                comando.Parameters.AddWithValue("@descripcion", inParametro.descripcion);
                comando.Parameters.AddWithValue("@num_i", inParametro.num_i);
                comando.Parameters.AddWithValue("@dFecha", inParametro.dFecha);
                comando.Parameters.AddWithValue("@hFecha", inParametro.hFecha);
                comando.Parameters.AddWithValue("@valStr", inParametro.valStr);
                comando.Parameters.AddWithValue("@pVz", inParametro.pvez);
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
