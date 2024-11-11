﻿using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Views
{
    public class InterfaceAnalista
    {
        public void Imprimir()
        {
            Console.WriteLine("AAAAA   N   N  AAAAA  L       III  SSS    TTTT   AAAAA");
            Console.WriteLine("A   A   NN  N  A   A  L        I  S        TT    A   A");
            Console.WriteLine("AAAAA   N N N  AAAAA  L        I   SSS     TT    AAAAA");
            Console.WriteLine("A   A   N  NN  A   A  L        I      S    TT    A   A");
            Console.WriteLine("A   A   N   N  A   A  LLLLL   III  SSSS    TT    A   A");
            Console.WriteLine();
        }

        public void Menu()
        {
            Console.WriteLine("\n----- Menu -----");
            Console.WriteLine("1. Exibir Vendedores");
            Console.WriteLine("2. Exibir Clientes");
            Console.WriteLine("3. Exportar Vendas");
            Console.WriteLine("4. Exportar Vendedores");
            Console.WriteLine("5. Exportar Clientes");
            Console.WriteLine("6. Exportar Estoque");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
        }

    }
}
