using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace RadugaTur
{
    static class Database
    {
        private static SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RadugaDB;Integrated Security=True");
        internal static void executeQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, Database.connection);
            if (command.Connection.State != System.Data.ConnectionState.Open) command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
