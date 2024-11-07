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
    public class Cliente : Pessoa, IAutenticavel
    {
        public string ID_Cliente { get; private set; }
        private string Senha { get; set; }
        private AutenticacaoUtil Autenticador { get; set; }
        public Cliente(string nome, string cpf, string senha) : base(nome, cpf)
        {
            Senha = senha;
            ID_Cliente = Guid.NewGuid().ToString();
            Autenticador = new AutenticacaoUtil();
        }

        public Cliente(string nome, int idade, string cpf, string senha) : base(nome, idade, cpf)
        {
            Senha = senha;
            ID_Cliente = Guid.NewGuid().ToString();
            Autenticador = new AutenticacaoUtil();
        }

        public Cliente(string nome, int idade, string cpf, Endereco endereco, string senha) : base(nome, idade, cpf, endereco)
        {
            Senha = senha;
            ID_Cliente = Guid.NewGuid().ToString();
            Autenticador = new AutenticacaoUtil();
        }

        public bool Autenticar(string email, string senha)
        {
            return this.Autenticador.AutenticarEmailSenha(this.Email, email, this.Senha, senha);
        }
    }
}
