using lolja_MODELOS.lolja.Modelos.Interfaces;
using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using lolja_MODELOS.lolja.Modelos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Pessoas
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private string Senha { get; set; }
        private AutenticacaoUtil Autenticador { get; set; }
        protected FuncionarioAutenticavel(string cargo, double salario, string nome, string cpf, string senha) : base(cargo, salario, nome, cpf)
        {
            Senha = senha;
            Autenticador = new AutenticacaoUtil();
        }

        protected FuncionarioAutenticavel(string cargo, double salario, string nome, int idade, string cpf, string senha) : base(cargo, salario, nome, idade, cpf)
        {
            Senha = senha;
            Autenticador = new AutenticacaoUtil();
        }

        protected FuncionarioAutenticavel(string cargo, double salario, string nome, int idade, string cpf, Endereco endereco, string senha) : base(cargo, salario, nome, idade, cpf, endereco)
        {
            Senha = senha;
            Autenticador = new AutenticacaoUtil();
        }

        public bool Autenticar(string email, string senha)
        {
            return this.Autenticador.AutenticarEmailSenha(this.Email, email, this.Senha, senha);
        }
    }
}
