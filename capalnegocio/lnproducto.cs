using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaaccdatos;


namespace capalnegocio
{
    public class lnproducto
    {
        private acproducto producdatos = new acproducto();
        private DataTable tabla = new DataTable();

        public void altaProducto(String tproducto, String descripcion, Double precio, Int32 stock, Int32 stockMin, DateTime inFecha, DateTime outFecha)
        {
            try
            {
             
                descripcion = tproducto + "-" + descripcion;
                producdatos.nuevoproducto(tproducto, descripcion, precio, stock, stockMin, inFecha, outFecha);

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

            tabla= producdatos.todosProductos();
            return tabla;
        }

        public DataTable mostrarUltimo()
        {
             tabla = null;
            tabla = producdatos.ultimoProducto();
            return tabla;



        }

    }
}
