using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using capaaccdatos;

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
