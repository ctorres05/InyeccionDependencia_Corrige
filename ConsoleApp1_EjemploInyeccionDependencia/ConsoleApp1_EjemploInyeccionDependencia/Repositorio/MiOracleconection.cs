using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public  class MiOracleconection : ConectioBD
    {
        public MiOracleconection() 
        {
            Console.WriteLine("La coinexion de la base de datos es SQL ORACLE");
        }

        public void ConectarBD(string cadenaconexion)
        {
            Console.WriteLine(" **** ORAC " + cadenaconexion);

        }
    }
}
