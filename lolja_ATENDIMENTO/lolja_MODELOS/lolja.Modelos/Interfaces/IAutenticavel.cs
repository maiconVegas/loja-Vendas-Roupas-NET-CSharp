using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Interfaces
{
    public interface IAutenticavel
    {
        bool Autenticar(string email, string senha);
    }
}
