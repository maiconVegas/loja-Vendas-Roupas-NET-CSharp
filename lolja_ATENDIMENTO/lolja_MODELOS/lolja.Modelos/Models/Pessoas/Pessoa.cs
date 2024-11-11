using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Pessoas
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; private set; }
        public string Email { get; set; }
        public Endereco EnderecoPessoa { get; set; }

        protected Pessoa(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        protected Pessoa(string nome, int idade, string cpf)
        {
            Nome= nome;
            Idade = idade;
            CPF = cpf;
        }

        protected Pessoa(string nome, int idade, string cpf, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            EnderecoPessoa = endereco;
        }
    }
}
