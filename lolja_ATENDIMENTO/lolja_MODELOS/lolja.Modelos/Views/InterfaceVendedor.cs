using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Views
{
    public class InterfaceVendedor
    {
        public void Imprimir()
        {
            Console.WriteLine(" V   V  EEEEE N   N DDDD   EEEEE  DDDD   OOO  RRRR ");
            Console.WriteLine(" V   V  E     NN  N D   D  E      D   D O   O R   R");
            Console.WriteLine(" V   V  EEEE  N N N D   D  EEEE   D   D O   O RRRR ");
            Console.WriteLine(" V   V  E     N  NN D   D  E      D   D O   O R  R ");
            Console.WriteLine("  VVV   EEEEE N   N DDDD   EEEEE  DDDD   OOO  R   R");
            Console.WriteLine();
        }

        public void Menu()
        {
            Console.WriteLine("\n----- Menu -----");
            Console.WriteLine("1. Consultar Estoque");
            Console.WriteLine("2. Cadastrar Cliente");
            Console.WriteLine("3. Vender para Cliente");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
        }
    }
}
