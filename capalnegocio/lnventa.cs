using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using capaaccdatos;

namespace capalnegocio
{
    public class lnventa
    {
        private DataTable tabla = new DataTable();
        private acventa ventaAC = new acventa();
        public string LNdetalleVenta(int codProd, string tipoProd, int codPromo,int cantidad, string descripcion, double total, DateTime fecha)
        {

            string resultado;
            try
            {
                

                resultado = ventaAC.detalleVenta(codProd, tipoProd, codPromo, cantidad, descripcion, total, fecha);

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }


        public void LNnuevaVenta(double total, DateTime fecha)
        {
            try
            {
                ventaAC.nuevaVenta(total, fecha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public DataTable LNbuscarDetalle(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                tabla = null;
                tabla = ventaAC.buscarDetalleVta(fechaInicio, fechaFin);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
           
        }

        public DataTable todoDetalleVta()
        {
            try
            {
                tabla = null;
                tabla = ventaAC.todoDetalleVta();
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable buscarPorTipoProducto(string tProducto)
        {
            try
            {
                tabla = null;
                tabla = ventaAC.buscarPorTipoProducto(tProducto);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
