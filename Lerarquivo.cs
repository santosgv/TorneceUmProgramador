using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TorneceUmProgramador
{
    class Lerarquivo
    {
        public static void LerArquivo(int Arquivo)
        {
            string caminho = @"C:\Users\vitorgomes\source\repos\TorneceUmProgramador\Arquivos\arquivo" + (Arquivo) +".txt";
            File.Copy(caminho, caminho+"CONV");
            if (File.Exists(caminho))
            {
                using (StreamReader arquivo = File.OpenText(caminho))
                {
                    string linha;

                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        try
                        {
                            string[] dados = linha.Split(',');
                            Console.WriteLine($"Cliente {dados[0]} com idade {dados[1]} nasceu em {dados[2]} pedido {dados[3]}");
                        }
                        catch (SystemException msg) { Console.WriteLine($"Erro sem pedido "); }
                    }
                   
                }

                string caminho2= @"C:\Users\vitorgomes\source\repos\TorneceUmProgramador\Arquivos\arquivo" + (Arquivo +1) + ".txt";
                if (File.Exists(caminho2))
                {
                    LerArquivo(Arquivo + 1);
                   
                }
            }
            else
                Console.WriteLine("Nao a arquivo para serem listado");
        }
    }
}
