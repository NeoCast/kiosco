using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace capaaccdatos
{
    class conexionbd
    {
        private SqlConnection conexion = new SqlConnection("Data Source = DESKTOP - K3J4GCO; Initial Catalog = Kiosco; Integrated Security = false; database=Kiosco;uid=neocast;password=kakashiI1223");
        
        public SqlConnection abrircn()
        {
           
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
                return conexion;
            }
            else
            {
                return conexion;

            }
        
        }

        public SqlConnection cerrarcn()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Close();
                return conexion;
            }
            else
            {
                return conexion;
            }

        }

    }
}
