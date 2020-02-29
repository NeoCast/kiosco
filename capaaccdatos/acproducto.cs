using System;
using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    public class acproducto
    {



        private conexionbd conexion = new conexionbd();
        public void nuevoproducto(String codBarra, String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha, Double costos)
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "altaProductos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codBarra", codBarra);
                comando.Parameters.AddWithValue("@tipoProd", tproducto);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@stockMin", stockMin);
                comando.Parameters.AddWithValue("@inFecha", inFecha);
                comando.Parameters.AddWithValue("@outFecha", outFecha);
                comando.Parameters.AddWithValue("@costos", costos);
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


        public DataTable todosProductos()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandText = "todosProductos";
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

        public DataTable ultimoProducto()
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            comando.Connection = conexion.abrircn();
            comando.CommandText = "ultimoProducto";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            tabla.Load(reader);
            conexion.cerrarcn();
            return tabla;

        }



        public DataTable buscarProducto(String descripcion)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "buscarProducto";
                comando.Parameters.AddWithValue("descripcion", descripcion);
                reader = comando.ExecuteReader();
                tabla.Load(reader);
                comando.Connection = conexion.cerrarcn();
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

        public void eliminarProducto(int idProducto)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "eliminarProducto";
                comando.Parameters.AddWithValue("codProducto", idProducto);
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

        public void modificarProducto(Int32 codProducto,String codBarra, String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin,Double costos)
        {

            SqlCommand comando = new SqlCommand();

            try
            {


                comando.Connection = conexion.abrircn();
                comando.CommandText = "modificarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProducto", codProducto);
                comando.Parameters.AddWithValue("@codBarra", codBarra);
                comando.Parameters.AddWithValue("@tipoProducto", tproducto);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@stockMin", stockMin);
                comando.Parameters.AddWithValue("@costos", costos);
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

        public DataTable buscarPorTproducto(string tipoProd)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {

                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "buscarProdTipo";
                comando.Parameters.AddWithValue("@tipoProd", tipoProd);
                reader = comando.ExecuteReader();
                tabla.Load(reader);
                comando.Connection = conexion.cerrarcn();
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

        // busqueda por cod barras
        public DataTable buscarBarra(String codBarra)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "buscarBarra";
                comando.Parameters.AddWithValue("codBarra", codBarra);
                reader = comando.ExecuteReader();
                tabla.Load(reader);
                comando.Connection = conexion.cerrarcn();
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
