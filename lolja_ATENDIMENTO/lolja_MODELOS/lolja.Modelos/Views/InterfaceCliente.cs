using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Views
{
    public class InterfaceCliente
    {
        public void Imprimir()
        {
            Console.WriteLine(" CCCC  L      I  EEEEE N   N TTTTT EEEEE");
            Console.WriteLine("C      L      I  E     NN  N   T   E");
            Console.WriteLine("C      L      I  EEEE  N N N   T   EEEE");
            Console.WriteLine("C      L      I  E     N  NN   T   E");
            Console.WriteLine(" CCCC  LLLLL III EEEEE N   N   T   EEEEE");
            Console.WriteLine();
        }

        public void Menu()
        {
            Console.WriteLine("\n----- Menu -----");
            Console.WriteLine("1. Consultar produtos disponíveis");
            Console.WriteLine("2. Consultar produto por nome");
            Console.WriteLine("3. Adicionar produto no carrinho");
            Console.WriteLine("4. Listar carrinho");
            Console.WriteLine("5. Finalizar compra");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
        }
    }
}
