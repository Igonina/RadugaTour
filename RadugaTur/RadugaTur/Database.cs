using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace RadugaTur
{
    static class Database
    {
        private static SqlConnection connection = new SqlConnection("Data Source=ms-sql-6.in-solve.ru; Initial Catalog=1gb_rrrrr; User ID=1gb_radugakhv; Password=9995ac11tyu;");
        internal static SqlDataReader executeQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, Database.connection);
            if (command.Connection.State != System.Data.ConnectionState.Open) command.Connection.Open();
            return command.ExecuteReader();// NonQuery();
        }
    }
}
