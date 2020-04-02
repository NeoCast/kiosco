using capaaccdatos;
using System;
using System.Data;
using capaentidades;


namespace capalnegocio
{
    public class lnpromocion
    {
        #region "variable de clase"

        private acpromocion acPromo = new acpromocion();
        private DataTable tabla = new DataTable();


        #endregion

        /// <summary>
        /// Cargar nueva promocion
        /// </summary>
        /// <param name="promo"></param>
        public void nuevaPromo(promocion promo)
        {
            try
            {
               // capaentidades.acPromo promo = new capaentidades.acPromo();
                tabla = null;
                acPromo.nuevaPromo(promo);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public DataTable buscarPromos()
        {
            try
            {
                tabla = null;
                tabla = acPromo.buscarPromos();
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
                tabla = acPromo.masPromos();
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void eliminarPromocion(Int32 codPromo)
        {
            try
            {

                acPromo.eliminarPromocion(codPromo);


            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

    }
}
   