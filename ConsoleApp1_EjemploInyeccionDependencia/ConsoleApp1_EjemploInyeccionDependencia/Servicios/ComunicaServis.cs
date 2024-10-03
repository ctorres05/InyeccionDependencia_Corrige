using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Servicios
{
    public class ComunicationServis
    {
        //private EmailServis _emailServis;

        private Sender  _sender;


        public ComunicationServis(Sender sender)
        {
            //_emailServis = new EmailServis();
            _sender = sender;

        }

        public void SendMenssage(ClientesBanco clientesBanco, string menssage)
        {
            //_emailServis.Send(clientesBanco, menssage);
            
             _sender.SendMensagge(clientesBanco, menssage);  

        }
    }
}
