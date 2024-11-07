using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Pessoas
{
    public abstract class Funcionario : Pessoa
    {
        public string Cargo { get; private set; }
        public double Salario { get; private set; }

        protected Funcionario(string cargo, double salario, string nome, string cpf) : base(nome, cpf)
        {
            Cargo = cargo;
            Salario = salario;
        }
        //protected Funcionario(string cargo, double salario, string nome, string cpf) : base(nome, cpf)
        //{
        //    Cargo = cargo;
        //    Salario = salario;
        //}

        protected Funcionario(string cargo, double salario, string nome, int idade, string cpf) : base(nome, idade, cpf)
        {
            Cargo = cargo;
            Salario = salario;
        }

        protected Funcionario(string cargo, double salario, string nome, int idade, string cpf, Endereco endereco) : base(nome, idade, cpf, endereco)
        {
            Cargo = cargo;
            Salario = salario;
        }
    }
}
