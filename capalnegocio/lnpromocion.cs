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
