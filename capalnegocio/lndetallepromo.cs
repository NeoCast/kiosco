using capaaccdatos;
using capaentidades;
using System;
using System.Data;

namespace capalnegocio
{
    public class lndetallepromo
    {
        private acdetallePromo detalle = new acdetallePromo();
        private DataTable tabla = new DataTable();

        public void nuevoDetallePromo(detallePromocion dtPromo)
        {
            try
            {
                detalle.nuevoDetallePromo(dtPromo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }
      

     }
}