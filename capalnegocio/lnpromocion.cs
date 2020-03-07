using capaaccdatos;
using System;
using System.Data;


namespace capalnegocio
{
    public class lnpromocion
    {
        private acpromocion promocion = new acpromocion();
        private DataTable tabla = new DataTable();

        /// <summary>
        /// Alta de promocion
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="total"></param>
        /// <param name="activa"></param>
        public void nuevaPromo(string descripcion, double total, int activa)
        {
            try
            {
                tabla = null;
                promocion.nuevaPromo(descripcion, total, activa);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

     

        /// <summary>
        /// Busca las promociones existentes
        /// </summary>
        /// <returns></returns>
        public DataTable buscarPromos()
        {
            try
            {
                tabla = null;
                tabla = promocion.buscarPromos();
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        
        public DataTable buscarDetallepromo()
        {
            try
            {
                tabla = null;
                tabla = promocion.masPromos();
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
   