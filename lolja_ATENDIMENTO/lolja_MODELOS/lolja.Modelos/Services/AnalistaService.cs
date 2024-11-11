using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using lolja_MODELOS.lolja.Modelos.Models.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lolja_MODELOS.lolja.Modelos.Services
{
    public class AnalistaService
    {
        public void ExibirVendedores(List<Vendedor> vendedores)
        {
            Console.Clear();
            if (vendedores != null)
            {
                foreach (var vendedor in vendedores)
                {
                    Console.WriteLine($"================ Vendedor ================");
                    Console.WriteLine($"ID: {vendedor.ID_Vendedor}");
                    Console.WriteLine($"Nome: {vendedor.Nome}");
                    Console.WriteLine($"Idade: {vendedor.Idade}");
                    Console.WriteLine($"CPF: {vendedor.CPF}");
                    Console.WriteLine($"Email: {vendedor.Email}");
                    Console.WriteLine($"Endereço: {vendedor.EnderecoPessoa.Rua}, {vendedor.EnderecoPessoa.Numero}, " +
                        $"{vendedor.EnderecoPessoa.Bairro}, {vendedor.EnderecoPessoa.CEP}, " +
                        $"{vendedor.EnderecoPessoa.CidadeEndereco.Nome}, " +
                        $"{vendedor.EnderecoPessoa.CidadeEndereco.EstadoCidade.Nome} - " +
                        $"{vendedor.EnderecoPessoa.CidadeEndereco.EstadoCidade.Sigla}");
                    Console.WriteLine($"Cargo: {vendedor.Cargo}");
                    Console.WriteLine($"Salário: {vendedor.Salario.ToString("C")}");
                    Console.WriteLine("===========================================\n\n");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Vendedores Indisponiveis!");
            }
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExibirClientes(List<Cliente> clientes)
        {
            Console.Clear();
            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"================ Cliente ================");
                    Console.WriteLine($"ID: {cliente.ID_Cliente}");
                    Console.WriteLine($"Nome: {cliente.Nome}");
                    Console.WriteLine($"Idade: {cliente.Idade}");
                    Console.WriteLine($"CPF: {cliente.CPF}");
                    Console.WriteLine($"Email: {cliente.Email}");
                    Console.WriteLine($"Endereço: {cliente.EnderecoPessoa.Rua}, {cliente.EnderecoPessoa.Numero}, " +
                        $"{cliente.EnderecoPessoa.Bairro}, {cliente.EnderecoPessoa.CEP}, " +
                        $"{cliente.EnderecoPessoa.CidadeEndereco.Nome}, " +
                        $"{cliente.EnderecoPessoa.CidadeEndereco.EstadoCidade.Nome} - " +
                        $"{cliente.EnderecoPessoa.CidadeEndereco.EstadoCidade.Sigla}");
                    Console.WriteLine("===========================================\n\n");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Clientes Indisponiveis!");
            }
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
