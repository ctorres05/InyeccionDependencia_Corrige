// See https://aka.ms/new-console-template for more information

using ConsoleApp1_EjemploInyeccionDependencia;
using ConsoleApp1_EjemploInyeccionDependencia.Repositorio;
using ConsoleApp1_EjemploInyeccionDependencia.Servicios;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1_EjemploInyeccionDependencia
{

    class Program
    {


        static void Main(String[] arg)
        {
            Console.WriteLine("**********>>> Prueba de Inyeccion de Dpenddencia <<<< ********");
            Console.WriteLine("Subo esto a GitHub");


            var _serviCli = new ClientesServis();
            var _provCLi = new ProveedorServis();



            var sms = new SmsServices();   /*Inyeccion de dependiencia*/
            var email = new EmailServis();   /*Inyeccion de dependiencia*/


            var _comunicationservice = new ComunicationServis(sms);    /*Imyeccion*/
            var _comunicationservice2 = new ComunicationServis(email);


            /*var _repocli = new ClientesBancoRepositorio();*/

            var _ClientesBanco      = _serviCli.GetClientesBancos();
            var _ProveedorCLi       = _provCLi.GetProveedorBancos();

            Console.WriteLine("--------------- Clientes -----------------------");

            foreach (var Cli in _ClientesBanco)
            {
                Console.WriteLine($"Nombre del cliente:  {Cli.Nombre}  email: {Cli.Email}  MA ver ");
            }

            Console.WriteLine("--------------- Proveedores-----------------------");

            foreach (var Prov in _ProveedorCLi)
            {
                Console.WriteLine($"Nombre del Proveedor:  {Prov.Id}  email: {Prov.NomProv}  MA ver ");
            }


            Console.WriteLine("--------------- Envio de Mails a Clientes-----------------------");


            foreach (var Cli in _ClientesBanco)
            {
                _comunicationservice.SendMenssage(Cli, "Hola va el mensaje");
                _comunicationservice2.SendMenssage(Cli, "Hola va el mensaje");

            }

        }


    }


}


       



