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

        public parametro consultaIsInstall()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            parametro serial = new parametro();
            try
            {
               
                comando.Connection = conexion.abrircn();
                comando.CommandText = "select top 1 * from parametros where idParametro= SERIAL";
                comando.CommandType = CommandType.Text;
                reader = comando.ExecuteReader();
                //serial = comando.ExecuteScalar();
                //while (reader.Read())
                //{

                //}
             
                serial.idParametro = Convert.ToString(tabla.Rows[0][0]);
                serial.descripcion = Convert.ToString(tabla.Rows[0][1]);
                serial.valorNum = Convert.ToInt32(tabla.Rows[0][2]);
                serial.valorStr = Convert.ToString(tabla.Rows[0][3]);
                serial.valorFecha = Convert.ToDateTime(tabla.Rows[0][4]);

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

        public void modificarParametro(parametro inParametro)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            parametro serial = new parametro();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "updatePar";
                comando.Parameters.AddWithValue("@idParametro", inParametro.idParametro);
                comando.Parameters.AddWithValue("@descripcion", inParametro.descripcion);
                comando.Parameters.AddWithValue("@valorNum", inParametro.valorNum);
                comando.Parameters.AddWithValue("@valorStr", inParametro.valorStr);
                comando.Parameters.AddWithValue("@valorFecha", inParametro.valorFecha);
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
