using capaaccdatos;
using System;
using System.Data;


namespace capalnegocio
{
    public class lnproducto
    {
        private acproducto producdatos = new acproducto();
        private DataTable tabla = new DataTable();

        public void altaProducto(String codBarra, String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha, Double costos)
        {
            try
            {

                tabla = null;
                descripcion = tproducto + "-" + descripcion;
                producdatos.nuevoproducto(codBarra, tproducto, descripcion, precio, stock, stockMin, inFecha, outFecha, costos);

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        public DataTable mostrarProductos(string codBarra,string descripcion)
        {
            tabla = null;
            codBarra = Convert.ToString(codBarra);
            codBarra = Convert.ToString(descripcion);
            tabla = producdatos.buscarProducto(codBarra, descripcion);
            return tabla;


        }

        public DataTable mostrarTodos()
        {

            tabla = null;
            tabla = producdatos.todosProductos();
            return tabla;

        }

        public DataTable mostrarUltimo()
        {

            tabla = null;
            tabla = producdatos.ultimoProducto();
            return tabla;


        }

        public void eliminarProducto(Int32 codProd)
        {
            try
            {

                producdatos.eliminarProducto(codProd);


            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public void modificarProducto(Int32 codProd,string codBarra, string tipoProd, string descripcion, double precio, Int32 stock, Int32 stockMin,double costos)
        {
            try
            {
                producdatos.modificarProducto(codProd,codBarra, tipoProd, descripcion, precio, stock, stockMin,costos);

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        public DataTable buscarPorTproducto(string tipoProd)
        {
            tabla = null;
            tabla =  producdatos.buscarPorTproducto(tipoProd);
            return tabla;
        }

    }
}
