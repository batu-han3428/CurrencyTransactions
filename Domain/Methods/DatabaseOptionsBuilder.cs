using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Domain.Methods
{
    public class DatabaseOptionsBuilder
    {
        public SqlConnection createDatabase(string databaseName)
        {
            string query = "select name from sys.databases where name='" + databaseName + "'";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J0S4R9L;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                SqlConnection baglanti = new SqlConnection("server=DESKTOP-J0S4R9L;database='" + databaseName + "';Trusted_Connection=true;");
                return baglanti;
            }
            else
            {
                
                SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J0S4R9L;Initial Catalog=master;Integrated Security=True");
                baglanti.Open();
            
                SqlCommand cmd = new SqlCommand("newDatabase", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@databaseName", databaseName);
                cmd.Parameters.AddWithValue("@databaseNameLog", databaseName+"_Log");          
                cmd.ExecuteNonQuery();              
                baglanti.Close();
                baglanti.Dispose();

                SqlConnection baglanti1 = new SqlConnection("server=DESKTOP-J0S4R9L;database='" + databaseName + "';Trusted_Connection=true;");

                return baglanti1;
            }
        }

        public string queryTable(SqlConnection connection)
        {       
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) as 'tableCount' from sys.tables where type_desc = 'USER_TABLE'", connection);
            SqlDataReader read = command.ExecuteReader();
            
            while (read.Read())
            {
                string data = read["tableCount"].ToString();

                connection.Close();

                return data;
            }
            return "hata";
        }

        public bool checkTable(string tableCount)
        {
            if (Convert.ToInt32(tableCount) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
