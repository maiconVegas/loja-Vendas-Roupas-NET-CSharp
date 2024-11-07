using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Utils
{
    internal class AutenticacaoUtil
    {
        public bool AutenticarEmailSenha(string emailVerdadeiro, string emailTentativa, string senhaVerdadeira, string senhaTentativa)
        {
            if (ValidarCredenciais(emailVerdadeiro, emailTentativa, senhaVerdadeira, senhaTentativa))
            {
                if (ValidarEmail(emailVerdadeiro, emailTentativa) && ValidarSenha(senhaVerdadeira, senhaTentativa))
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidarCredenciais(string a, string b, string c, string d)
        {
            return (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) ||
                string.IsNullOrEmpty(c) || string.IsNullOrEmpty(d)) ? false : true;
        }

        private bool ValidarEmail(string emailV, string emailT)
        {
            return emailT.Equals(emailV);
        }
        private bool ValidarSenha(string senhaV, string senhaT)
        {
            return senhaT.Equals(senhaV);
        }
    }
}
