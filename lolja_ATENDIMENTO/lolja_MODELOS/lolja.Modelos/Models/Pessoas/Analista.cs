using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Pessoas
{
    public class Analista : FuncionarioAutenticavel
    {
        public string ID_Analista { get; private set; }
        public Analista(double salario, string nome, string cpf, string senha) : base("Analista", salario, nome, cpf, senha)
        {
            ID_Analista = Guid.NewGuid().ToString();
        }

        public Analista(double salario, string nome, int idade, string cpf, string senha) : base("Analista", salario, nome, idade, cpf, senha)
        {
            ID_Analista = Guid.NewGuid().ToString();
        }

        public Analista(double salario, string nome, int idade, string cpf, Endereco endereco, string senha) : base("Analista", salario, nome, idade, cpf, endereco, senha)
        {
            ID_Analista = Guid.NewGuid().ToString();
        }
    }
}
