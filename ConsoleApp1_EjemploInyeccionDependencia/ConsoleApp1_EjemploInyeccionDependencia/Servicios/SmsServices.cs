using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Servicios
{
    public class SmsServices : Sender
    {
        public void SendMensagge (ClientesBanco clientebanco, string menssage)
        {
            Console.WriteLine($"Mensage Enviado a {clientebanco.Nombre} por SMS {clientebanco.Email} " + menssage);

        }
    }
}
