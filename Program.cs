using System;

namespace TorneceUmProgramador
{
   public class Program : Lerarquivo
    {
       public static void Main(string[] args)
        {
            Conexao banco = new Conexao();
   


            Lerarquivo.LerArquivo(0);
            banco.Conectar();


            Console.ReadLine();
        }
    }
}
