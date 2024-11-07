using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Enderecos
{
    public class Estado
    {
        public enum SiglaEstado
        {
            AC,  // Acre
            AL,  // Alagoas
            AM,  // Amazonas
            AP,  // Amapá
            BA,  // Bahia
            CE,  // Ceará
            DF,  // Distrito Federal
            ES,  // Espírito Santo
            GO,  // Goiás
            MA,  // Maranhão
            MT,  // Mato Grosso
            MS,  // Mato Grosso do Sul
            MG,  // Minas Gerais
            PA,  // Pará
            PB,  // Paraíba
            PE,  // Pernambuco
            PI,  // Piauí
            PR,  // Paraná
            RJ,  // Rio de Janeiro
            RN,  // Rio Grande do Norte
            RS,  // Rio Grande do Sul
            RO,  // Rondônia
            RR,  // Roraima
            SC,  // Santa Catarina
            SE,  // Sergipe
            SP,  // São Paulo
            TO   // Tocantins
        }
        public string Nome => ObterNome();

        public SiglaEstado Sigla{ get; private set; }

        public Estado(SiglaEstado siglaEstado)
        {
            Sigla = siglaEstado;
        }

        private string ObterNome()
        {
            switch (Sigla)
            {
                case SiglaEstado.AC:
                    return "Acre";
                case SiglaEstado.AL:
                    return "Alagoas";
                case SiglaEstado.AM:
                    return "Amazonas";
                case SiglaEstado.AP:
                    return "Amapá";
                case SiglaEstado.BA:
                    return "Bahia";
                case SiglaEstado.CE:
                    return "Ceará";
                case SiglaEstado.DF:
                    return "Distrito Federal";
                case SiglaEstado.ES:
                    return "Espírito Santo";
                case SiglaEstado.GO:
                    return "Goiás";
                case SiglaEstado.MA:
                    return "Maranhão";
                case SiglaEstado.MT:
                    return "Mato Grosso";
                case SiglaEstado.MS:
                    return "Mato Grosso do Sul";
                case SiglaEstado.MG:
                    return "Minas Gerais";
                case SiglaEstado.PA:
                    return "Pará";
                case SiglaEstado.PB:
                    return "Paraíba";
                case SiglaEstado.PE:
                    return "Pernambuco";
                case SiglaEstado.PI:
                    return "Piauí";
                case SiglaEstado.PR:
                    return "Paraná";
                case SiglaEstado.RJ:
                    return "Rio de Janeiro";
                case SiglaEstado.RN:
                    return "Rio Grande do Norte";
                case SiglaEstado.RS:
                    return "Rio Grande do Sul";
                case SiglaEstado.RO:
                    return "Rondônia";
                case SiglaEstado.RR:
                    return "Roraima";
                case SiglaEstado.SC:
                    return "Santa Catarina";
                case SiglaEstado.SE:
                    return "Sergipe";
                case SiglaEstado.SP:
                    return "São Paulo";
                case SiglaEstado.TO:
                    return "Tocantins";
                default:
                    return "Estado desconhecido";
            }
        }
    }
}
