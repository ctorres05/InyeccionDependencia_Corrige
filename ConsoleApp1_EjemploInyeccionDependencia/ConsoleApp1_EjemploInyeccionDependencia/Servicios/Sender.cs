using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Servicios
{
    public interface Sender
    {
        void SendMensagge(ClientesBanco clientebanco, string menssage);
                       
    }
}
