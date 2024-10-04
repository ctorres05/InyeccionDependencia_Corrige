using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_EjemploInyeccionDependencia;
using ConsoleApp1_EjemploInyeccionDependencia.Servicios;

namespace ConsoleApp1_EjemploInyeccionDependencia.Repositorio
{
    public class ClientesBancoRepositorio
    {
        private MiSqlconcection _miconctionsql;

        private MiOracleconection _oracle;
        private MiSqlconcection _sqlserver;

        private GestorConexionBD_2 _gestor2;



        public ClientesBancoRepositorio()
       {
           // _miconctionsql = new MiSqlconcection();
           _oracle = new MiOracleconection();
           var _gestor = new GestorConexionBD(_oracle); /*Imyeccion en el constructor*/
           _gestor.ConectarBD("11.159.33   IP DE CONEXION");

           _sqlserver = new MiSqlconcection();        
            var _gestor1 = new GestorConexionBD(_sqlserver);
            _gestor1.ConectarBD("2 do gestor1   11.155.999   IP DE CONEXIOBN PARA SQL");


            _gestor2 = new GestorConexionBD_2();
            _gestor2.conectionbd = _oracle;     /*Inyeccion de dependecia por PROPIEDAD*/
            _gestor2.ConectarBD("IP 999.999.999   Inyeccion  por propiedad *************************>>>>");

                       
            
           // _gestor2.ConectarBD("1-99-999  Inyeccion por PROPOIEDADDDDDD");
        }



        public List<ClientesBanco> GetClientesBancos()
        {
            return new List<ClientesBanco>
            {
                new ClientesBanco() { Id= 1, Email = "carlos@gmail.com", Nombre = "Carlos Torres"       , Tel = "3815776993"},
                new ClientesBanco() { Id= 2, Email = "carlos222@gmail.com", Nombre = "Carlos Torres2"      , Tel = "3815776993"},
                new ClientesBanco() { Id= 2, Email = "Fran@gmail.com", Nombre = "Carlos Torres Franco", Tel = "3815776993"},
                new ClientesBanco() { Id= 2, Email = "Contyos@gmail.com", Nombre = "Conty Franco", Tel = "3815776993"}
            };
        }
    }

    public class ProveedorBancoRepositorio
    {
        public List<ProveedorBanco> GetProveedorBancos()
        {
            return new List<ProveedorBanco>
            {
                 new ProveedorBanco() { Id= 11, NomProv= "MAFRE" },
                 new ProveedorBanco() { Id= 10, NomProv= "SAN CRISTOBAL" }

            };
        }
    }

}
    
