using capaaccdatos;
using System;
using System.Data;

namespace capalnegocio
{
    public class lndetallepromo
    {
        private acdetallePromo detalle = new acdetallePromo();
        private DataTable tabla = new DataTable();

        public void nuevoDetallePromo(Int32 codProd, string descrProd,Int32 cantidad)
        {
            detalle.nuevoDetallePromo(codProd, descrProd, cantidad);
        }


    }
}
