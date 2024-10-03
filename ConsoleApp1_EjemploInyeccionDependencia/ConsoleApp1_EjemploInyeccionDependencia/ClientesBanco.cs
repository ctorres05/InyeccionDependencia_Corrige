using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia
{
    public class ClientesBanco
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set;  }
        public string Tel { get; set; }


    }

    public class ProveedorBanco
    {
        public int Id { get; set; } = 0;
        public string NomProv { get; set; }
        


    }
}
