﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class Repositorio
    {
        private readonly string connectionString;
        public Repositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Trabajo_Programación"].ToString();
        }
        protected SqlConnection ObtenerConexion ()

        {
            return new SqlConnection(connectionString);
}
    }
}