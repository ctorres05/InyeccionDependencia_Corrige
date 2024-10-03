using ConsoleApp1_EjemploInyeccionDependencia.Repositorio;
using ConsoleApp1_EjemploInyeccionDependencia;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EjemploInyeccionDependencia.Servicios
{
    public class ClientesServis
    {
        private ClientesBancoRepositorio _repository;

        public ClientesServis()
        {
               _repository = new ClientesBancoRepositorio();


        }

        public List<ClientesBanco> GetClientesBancos()
        {
            return _repository.GetClientesBancos();
        }


    }

    public class ProveedorServis
    {
        private ProveedorBancoRepositorio _respositoryprov; 

        public ProveedorServis()
        {
            _respositoryprov = new ProveedorBancoRepositorio(); 
        }

        public List<ProveedorBanco> GetProveedorBancos()
        {
            return _respositoryprov.GetProveedorBancos();

        }

    }
}
