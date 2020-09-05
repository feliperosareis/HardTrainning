using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ConnectorDAO
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=hardtraining;uid=root;pwd=");

        public void connect()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void executeQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable result(string query)
        {
            DataTable data = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder buider = new MySqlCommandBuilder(adapt);
            adapt.Fill(data);

            return data;
        }

        public MySqlDataReader resultset(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            return reader;
        }
    }
}
