using Domain.Concrete;
using Domain.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace Domain.Contexts
{
    public class SqlDbContext<T>:Database where T:class
    {
        DatabaseOptionsBuilder database;
        SqlConnection sqlConnection;
        string tableCount;
        bool activeTable;
        public SqlDbContext()
        {
            this.database = new DatabaseOptionsBuilder();
        }

        protected override void databaseConfiguring(DatabaseOptionsBuilder database)
        {
            sqlConnection = database.createDatabase("currency");
            tableCount = database.queryTable(sqlConnection);
            activeTable = database.checkTable(tableCount);
        }

        public string takeAction(T data, string procName, processType type)
        {

            databaseConfiguring(database);
            
            if (activeTable)
            {
                string result ="";
                string json = JsonSerializer.Serialize(data);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(procName, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inputData", json);
                if (type == 0)
                {
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                       result = read["data"].ToString();
                    }
                }
                else
                {
                    SqlParameter output = new SqlParameter("@outputData", SqlDbType.NVarChar,-1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(output);
                    cmd.ExecuteNonQuery();
                    result = (string)output.Value;
                }
               
                sqlConnection.Close();
                sqlConnection.Dispose();

               return result;
            }


            return "tablo yok";
        }

        
    }
}
