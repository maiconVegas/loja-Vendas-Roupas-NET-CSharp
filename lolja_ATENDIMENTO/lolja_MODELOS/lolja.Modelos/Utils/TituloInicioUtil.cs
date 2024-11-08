using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Utils
{
    public class TituloInicioUtil
    {
        public void TituloInicio()
        {
            string welcomeText = "                Bem-vindo à LOLJA!                ";
            Console.WriteLine(" ");
            Console.WriteLine("   ██╗      ██████╗  ██╗           ██╗  █████╗    ");
            Console.WriteLine("   ██║     ██╔═══██╗ ██║           ██║ ██╔══██╗   ");
            Console.WriteLine("   ██║     ██║   ██║ ██║           ██║ ███████║   ");
            Console.WriteLine("   ██║     ██║   ██║ ██║      ██   ██║ ██╔══██║   ");
            Console.WriteLine("   ███████╗╚██████╔╝ ███████╗ ╚█████╔╝ ██║  ██║   ");
            Console.WriteLine("   ╚══════╝ ╚═════╝  ╚══════╝  ╚════╝  ╚═╝  ╚═╝   ");
            Console.WriteLine("                                                  ");
            Console.WriteLine(" ");
            foreach (char letter in welcomeText)
            {

                Console.Write(letter);
                Thread.Sleep(50);

            }
            
        }
    }
}
