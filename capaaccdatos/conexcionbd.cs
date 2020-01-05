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
    class conexcionbd
    {
        private SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Kiosco;Integrated Security=True");
        
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
