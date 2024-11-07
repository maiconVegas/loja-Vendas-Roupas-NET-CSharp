using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Enderecos
{
    public class Cidade
    {
        public string Nome { get; private set; }
        public Estado EstadoCidade{ get; private set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            EstadoCidade = estado;
        }
    }
}
