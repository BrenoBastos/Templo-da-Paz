using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    public  class Conexao
    {
        public static MySqlConnection con = new MySqlConnection("server=127.0.0.1:3307;database=necroterio;user id=root;password=root;");
        public void Abrir(){
            con.Open();
        }
        public void Fechar()
        {
            con.Close();
        }
    }
}
