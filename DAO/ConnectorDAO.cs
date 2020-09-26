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
        // Instância da conexão com o banco de dados.
        MySqlConnection conn = new MySqlConnection("server=localhost;database=hardtraining;uid=root;pwd=");

        // Método para conexao com o banco de dados.
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

        // Método para Inclusão e Atualização.
        public void executeQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Método para consulta.
        public DataTable result(string query)
        {
            DataTable data = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder buider = new MySqlCommandBuilder(adapt);
            adapt.Fill(data);

            return data;
        }
    }
}
