using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public class GestorConexionBD_2
    {
        private ConectioBD? _conectionbd;
        public ConectioBD conectionbd
        {

            get => _conectionbd;

            set
            { _conectionbd = value; }
        }

        public void ConectarBD(string _cadenaconexion)
        {

            conectionbd.ConectarBD(_cadenaconexion);
            

        }
    }
}

