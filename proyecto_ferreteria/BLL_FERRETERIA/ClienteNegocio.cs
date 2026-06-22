using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_FERRETERIA
{
    public class ClienteNegocio
    {
        public bool CrearCliente(ENTIDADES.FERRETERIA.ClienteBE ClienteEntidad)
        {
            DAL_FERRETERIA.ClienteDatos clienteDal = new ClienteDatos();
            return clienteDal.CrearCliente(ClienteEntidad);

        }

        public List <ClienteBE> ListarClientes()
        {
            ClienteDatos clienteDal = new ClienteDatos();
            return clienteDal.ListarClientes();
        }
    
      
        public List<ClienteBE> BuscarClientes(string criterio, string valor)
        {

            ClienteDatos clienteDal = new ClienteDatos();
            switch (criterio)
            {
                case "ID": 
                    return clienteDal.BuscarPorId(valor);

                case "DNI":
                    return clienteDal.BuscarPorDNI(valor);

                case "CUIL":
                    return clienteDal.BuscarPorCuil(valor);

                case "RAZON SOCIAL":
                    return clienteDal.BuscarPorRazonSocial(valor);
                default:
                    throw new Exception("Criterio de búsqueda inválido.");
            }
        }

        public ClienteBE BuscarClientes(int valor)
        {

            ClienteDatos clienteDal = new ClienteDatos();
            
            return clienteDal.BuscarPorId(valor);
         }


        public bool ModificarCliente(ClienteBE clientemodificado)
        {

            ClienteDatos clienteDal = new ClienteDatos();

            return clienteDal.ModificarCliente(clientemodificado);

        }
    }
}
