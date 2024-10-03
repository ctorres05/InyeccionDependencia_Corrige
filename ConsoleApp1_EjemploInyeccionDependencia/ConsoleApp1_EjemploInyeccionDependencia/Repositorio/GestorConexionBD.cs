using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public class GestorConexionBD
    {

        private ConectioBD _conectioBD;

        public GestorConexionBD(ConectioBD conectioBD)

        {
            _conectioBD = conectioBD;
        }

        public void ConectarBD(string _cadenaconexion)
        {

            _conectioBD.ConectarBD( _cadenaconexion );


        }
    }
}
