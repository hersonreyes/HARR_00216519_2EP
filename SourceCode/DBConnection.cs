﻿
    using System.Data;
    using System.Windows.Forms;
    using Npgsql;

    namespace SourceCode
    {
        public static class ConnectionDB
        {
            private static string host = "127.0.0.1",
                database = "Parcial2",
                UserId = "postgres",
                password = "uca";
            
            
            private static string sConnection = 
                $"Server={host};Port=5432;User Id={UserId};Password={password};Database={database}";
        
            public static DataTable ExecuteQuery(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConnection);
                DataSet ds = new DataSet();
                connection.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }

            public static void ExecuteNonQuery(string act)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(act, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }  
        }
    }
    
