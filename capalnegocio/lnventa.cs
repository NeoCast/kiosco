using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaaccdatos;

namespace capalnegocio
{
    public class lnventa
    {

        private acventa ventaAC = new acventa();
        public void LNdetalleVenta(int codProd, int cantidad, string descripcion, double total, DateTime fecha)
        {
            ventaAC.detalleVenta(codProd, cantidad, descripcion, total, fecha);
        }


        public void LNnuevaVenta(double total, DateTime fecha)
        {
            ventaAC.nuevaVenta(total, fecha);
        }
    }
}
