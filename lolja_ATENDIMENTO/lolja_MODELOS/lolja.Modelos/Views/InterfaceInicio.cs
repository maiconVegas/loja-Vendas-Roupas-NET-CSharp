using lolja_MODELOS.lolja.Modelos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Views
{
    public class InterfaceInicio
    {
        public void IniciarInterface()
        {
            TituloInicioUtil titulo = new TituloInicioUtil();
            titulo.TituloInicio();
            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write("Digite algo: ");
            Console.ReadLine();
        }
        
        
    }
}
