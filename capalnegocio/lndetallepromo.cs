using capaaccdatos;
using System;
using System.Data;

namespace capalnegocio
{
    class lndetallepromo
    {
        private acdetallePromo detalle = new acdetallePromo();
        private DataTable tabla = new DataTable();

        public void nuevoDetallePromo(Int32 codPromo, Int32 codProd, string descrProd, double totalProd, Int32 cantidad)
        {
            detalle.nuevoDetallePromo(codPromo, codProd, descrProd, totalProd, cantidad);
        }


    }
}
