using capaaccdatos;
using System;
using System.Data;
using capaentidades;


namespace capalnegocio
{
    public class lnproducto
    {
        private acproducto producdatos = new acproducto();
        private DataTable tabla = new DataTable();

        public void altaProducto(String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha,Double costos)
        {
            try
            {
                productos producto = new productos();
                tabla = null;

                
                producto.tipoProducto = tproducto;
                producto.descripcion = descripcion;
                producto.precio = precio;
                producto.stock = stock;
                producto.stockMin = stockMin;
                producto.inFecha = inFecha;
                producto.outFecha = outFecha;
                producto.costos = costos;


                //descripcion = tproducto + "-" + descripcion;
                producdatos.nuevoproducto(producto);

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        public DataTable mostrarProductos(string descripcion)
        {
            tabla = null;

            descripcion = Convert.ToString(descripcion);

            tabla = producdatos.buscarProducto(descripcion);
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

        public void modificarProducto(Int32 codProd, string tipoProd, string descripcion, double precio, Int32 stock, Int32 stockMin,double costos)
        {
            try
            {
                producdatos.modificarProducto(codProd, tipoProd, descripcion, precio, stock, stockMin,costos);

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

        public DataTable mostrarPorVenc()
        {

            tabla = null;
            tabla = producdatos.todosProductoPorVenc();
            return tabla;

        }

    }
}
