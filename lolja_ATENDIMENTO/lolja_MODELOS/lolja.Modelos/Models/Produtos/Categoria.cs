using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Produtos
{
    public class Categoria
    {
        public int ID_Categoria { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Categoria(string nome, string descricao)
        {
            Random random = new Random();
            ID_Categoria = random.Next(1, 100000);
            Nome = nome;
            Descricao = descricao;
        }

        public void AlterarDescricao(string descricao)
        {
            if (descricao != null || descricao != " ")
            {
                Descricao = descricao;
            }
            else
            {
                Console.WriteLine("Descrição da Categoria vázio!");
            }
        }
    }
}
