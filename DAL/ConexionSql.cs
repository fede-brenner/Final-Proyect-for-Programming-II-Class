using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionSql
    {
        private readonly string connectionString;
        public ConexionSql()
        {
            connectionString = "Data Source=FEDEBRE\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
