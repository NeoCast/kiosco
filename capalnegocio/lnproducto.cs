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
            DataTable tabla = new DataTable();
            descripcion = Convert.ToString(descripcion);

            tabla = producdatos.buscarProducto(descripcion);
            return tabla;

        }
        
        public DataTable mostrarTodos()
        {
            DataTable tabla = new DataTable();

            tabla= producdatos.todosProductos();
            return tabla;
        }

    }
}
