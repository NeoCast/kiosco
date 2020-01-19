using capaaccdatos;
using System;
using System.Data;


namespace capalnegocio
{
    class lnpromocion
    {
        private acpromocion promocion = new acpromocion();
        private DataTable tabla = new DataTable();

        public void nuevaPromo(string descripcion, double total, bool activa)
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
    }
}
