using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public interface ConectioBD
    {
        void ConectarBD(string _cadenaconexion);
        
        
    }
}
