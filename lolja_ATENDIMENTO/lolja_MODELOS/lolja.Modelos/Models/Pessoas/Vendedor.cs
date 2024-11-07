using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using lolja_MODELOS.lolja.Modelos.Models.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Pessoas
{
    public class Vendedor : FuncionarioAutenticavel
    {
        public string ID_Vendedor { get; private set; }
        public Vendedor(double salario, string nome, string cpf, string senha) : base("Vendedor", salario, nome, cpf, senha)
        {
            ID_Vendedor = Guid.NewGuid().ToString();
        }

        public Vendedor(double salario, string nome, int idade, string cpf, string senha) : base("Vendedor", salario, nome, idade, cpf, senha)
        {
            ID_Vendedor = Guid.NewGuid().ToString();
        }

        public Vendedor(double salario, string nome, int idade, string cpf, Endereco endereco, string senha) : base("Vendedor", salario, nome, idade, cpf, endereco, senha)
        {
            ID_Vendedor = Guid.NewGuid().ToString();
        }
        //public Vendedor() : base("Vendedor", salario, nome, cpf, senha)
        //{
            
        //}
    }
}
