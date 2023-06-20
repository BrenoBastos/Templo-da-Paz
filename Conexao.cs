using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    using MySql.Data.MySqlClient;

    public class Conexao
    {
        public static MySqlConnection con;
        public static string connectionString = "server=127.0.0.1;port=3306;database=necroterio;user id=root;password=root;";

        public void Abrir()
        {
            con = new MySqlConnection(connectionString);
            con.Open();
        }

        public void Fechar()
        {
            con.Close();
        }
    }

}
