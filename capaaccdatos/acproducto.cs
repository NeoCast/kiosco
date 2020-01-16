﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace capaaccdatos
{                  
  public class acproducto
    {



        private conexionbd conexion = new conexionbd();
        public void nuevoproducto(String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha)
        {
              
             
           
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
        

            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "altaProductos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tipoProd", tproducto);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@stockMin", stockMin);
                comando.Parameters.AddWithValue("@inFecha", inFecha);
                comando.Parameters.AddWithValue("@outFecha", outFecha);
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
                conexion.cerrarcn();
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
                comando.Parameters.AddWithValue("descripcion", descripcion);
                reader = comando.ExecuteReader();
                tabla.Load(reader);
                conexion.cerrarcn();
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
                comando.Parameters.AddWithValue("idProducto", idProducto);
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

        public void modificarProducto(Int32 codProducto ,String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha)
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();


            try
            {
                comando.Connection = conexion.abrircn();
                comando.CommandText = "modificarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codProducto", codProducto);
                comando.Parameters.AddWithValue("@tipoProd", tproducto);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@stockMin", stockMin);
                comando.Parameters.AddWithValue("@inFecha", inFecha);
                comando.Parameters.AddWithValue("@outFecha", outFecha);
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
