using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capasoporte.Cache;
using capaaccdatos;


namespace capalnegocio
{
   
    public class lnusuario
    {
        private acusuarios datausu = new acusuarios();
        private DataTable tabla = new DataTable();


        public bool loginuser(string usuario, string contrasena)
        {
            return datausu.login(usuario,contrasena);
        }
        public void AnyMethod()
        {
            //Seguridad y permisos
            if (uCache.cargo == cargos.administrador)
            {
                // codigo
            }
            if (uCache.cargo == cargos.empleado)
            {
                // codigo
            }
        }
        public void altaUsuario(string usuario, string contrasena, string nombre, string cargo)
        {
            try
            {
                datausu.nuevoUsu(usuario, contrasena, nombre, cargo);              

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable mostrarTodos()
        {

            tabla = null;
            tabla = datausu.todosUsu();
            return tabla;

        }
        public void eliminarUsu(Int32 codUsu)
        {
            try
            {

                datausu.eliminarUsu(codUsu);

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }
    }
}
