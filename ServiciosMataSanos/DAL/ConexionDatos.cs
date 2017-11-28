using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionDatos
    {
        private static string con = @"Data Source=DESKTOP-PTPH7ST\MSSQLSERVER01;Initial Catalog=MataSanossBD;Integrated Security=True";

        public static IDbConnection conexion()
        {
            return new SqlConnection(con);
        }
        public static IDbCommand ObtenerComando(string pcomando, IDbConnection pcnn)
        {
            return new SqlCommand(pcomando, pcnn as SqlConnection);
        }
    }
}
