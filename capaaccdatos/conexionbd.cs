﻿using System.Data;
using System.Data.SqlClient;

namespace capaaccdatos
{
    class conexionbd
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
            if (conexion.State == ConnectionState.Open)
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
