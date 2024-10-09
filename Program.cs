using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LEGAL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao;
            MySqlConnection cmd;
            conexao = new MySqlConnection();

            try
            {
                string stringconexao = "server=localhost;uid=root;pwd='';database=TESTE";
                conexao.ConnectionString = stringconexao;
                conexao.Open();
                Console.WriteLine("conexão estabelecida");
                Console.ReadKey();
            }
            catch (MySqlException ex)
            {

                if (ex.Number == 1045)
                {
                    Console.WriteLine("banco esta ativo");
                }
                Console.WriteLine("ERRO GERADO:"+ex.Number);
                Console.WriteLine("ENtre em contato com o adm");
                Console.ReadKey();

            }

            string sql = "select * from usuario";



        }
    }
}
