using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneceUmProgramador
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao(){

            con.ConnectionString = @"Server = DESKTOP-APTIMI0\SQLEXPRESS; Database = IMPORTADOR; User Id = sa; Password = 7991";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed) { con.Open(); Console.WriteLine("Conectado"); }
            return con;
        }

        public void Desconecta()
        {
            if (con.State == System.Data.ConnectionState.Open) { con.Close();Console.WriteLine("Desconectado"); }
        }
    }
}
