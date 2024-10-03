using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public class MiSqlconcection : ConectioBD
    {
        public  MiSqlconcection ()
        {
            Console.WriteLine("La coinexion de la base de datos es SQL SERVER");
        }

        public void ConectarBD(string cadenaconexion)
        {
            Console.WriteLine($"La coinexion de la base de datos es SQL SERVER {cadenaconexion} ");

        }
    }
}
