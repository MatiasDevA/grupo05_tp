using ENTIDADES.FERRETERIA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL_FERRETERIA
{
    public class ClienteDatos
    {
        public bool CrearCliente(ClienteBE ClienteDatos)
        {
            Conexion objconexion = Conexion.GetInstance();
            SqlParameter[] misParametros
            = {
            objconexion.crearParametro("@CUIL", ClienteDatos.Cuil),
            objconexion.crearParametro("@Dni", ClienteDatos.DNI),
            objconexion.crearParametro("@RazonSocial",ClienteDatos.RazonSocial),
            objconexion.crearParametro("@Telefono", ClienteDatos.Telefono),
            objconexion.crearParametro("@Contacto",ClienteDatos.Contacto),
            objconexion.crearParametro("@IdUsuarioVendedor", 3)

            };

            return objconexion.EscribirPorStoreProcedure("SP_AltaCliente", misParametros) > 0;// si hay filas afectas es verdadero
        }

        public List<ClienteBE> ListarClientes()
        {
            Conexion objconexion = Conexion.GetInstance();
            List<ClienteBE> ListaRetorno = new List<ClienteBE>();

            foreach (System.Data.DataRow fila in objconexion.LeerPorStoreProcedure("SP_ListarClientes").Rows)
            {
                ClienteBE objCLiente = new ClienteBE();

                objCLiente.IDCliente = Convert.ToInt32(fila["id_cliente"]);
                objCLiente.Telefono = fila["telefono"].ToString();
                objCLiente.Contacto = fila["contacto"].ToString();
                objCLiente.RazonSocial = fila["razon_social"].ToString();
                objCLiente.Cuil = fila["cuil"].ToString();
                objCLiente.DNI = fila["dni"].ToString();
                ListaRetorno.Add(objCLiente);

            }
            return ListaRetorno;

        }

        public List<ClienteBE> BuscarPorDNI(string valor)
        {
            Conexion objConexion = Conexion.GetInstance();
            List<ClienteBE> valoresretornados = new List <ClienteBE>();
            SqlParameter[] parametros = {
               objConexion.crearParametro("@DNI",valor)};

            foreach (System.Data.DataRow fila in objConexion.LeerPorStoreProcedure("SP_BuscarClientePorDNI", parametros).Rows)
            {
                ClienteBE objCLiente = new ClienteBE();

                objCLiente.IDCliente = Convert.ToInt32(fila["id_cliente"]);
                objCLiente.Telefono = fila["telefono"].ToString();
                objCLiente.Contacto = fila["contacto"].ToString();
                objCLiente.RazonSocial = fila["razon_social"].ToString();
                objCLiente.Cuil = fila["cuil"].ToString();
                objCLiente.DNI = fila["dni"].ToString();
                valoresretornados.Add(objCLiente);
            }
            return valoresretornados;
        }

        public List<ClienteBE> BuscarPorId( string valor)
        {
            Conexion objConexion = Conexion.GetInstance();
            SqlParameter[] parametros =
            {
        objConexion.crearParametro("@ID",Convert.ToInt32(valor))
    };

            DataTable dt = objConexion.LeerPorStoreProcedure(
                "SP_BuscarClientePorID",
                parametros
            );

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            ClienteBE cliente = new ClienteBE();
            cliente.IDCliente = Convert.ToInt32(row["id_cliente"]);
            cliente.Contacto = row["contacto"].ToString();
            cliente.Cuil = row["cuil"].ToString();
            cliente.DNI = row["dni"].ToString();
            cliente.Telefono = row["telefono"].ToString();
            cliente.RazonSocial = row["razon_social"].ToString();

            List<ClienteBE> Retorno = new List<ClienteBE>();
           Retorno.Add(cliente);


            return Retorno;
        }

        public List<ClienteBE> BuscarPorCuil(string valor)
        {
            Conexion objConexion = Conexion.GetInstance();
            List<ClienteBE> valoresretornados = new List<ClienteBE>();
            SqlParameter[] parametros = {
                                         objConexion.crearParametro("@CUIL",valor)};

            foreach (System.Data.DataRow fila in objConexion.LeerPorStoreProcedure("SP_BuscarClientePorCuil", parametros).Rows)
            {
                ClienteBE objCLiente = new ClienteBE();

                objCLiente.IDCliente = Convert.ToInt32(fila["id_cliente"]);
                objCLiente.Telefono = fila["telefono"].ToString();
                objCLiente.Contacto = fila["contacto"].ToString();
                objCLiente.RazonSocial = fila["razon_social"].ToString();
                objCLiente.Cuil = fila["cuil"].ToString();
                objCLiente.DNI = fila["dni"].ToString();
                valoresretornados.Add(objCLiente);
            }
            return valoresretornados;

        }

        public List<ClienteBE> BuscarPorRazonSocial(string valor)
        {
            Conexion objConexion = Conexion.GetInstance();
            List<ClienteBE> valoresretornados = new List<ClienteBE>();
            SqlParameter[] parametros = {
                                      objConexion.crearParametro("@RazonSocial",valor)};

            foreach (System.Data.DataRow fila in objConexion.LeerPorStoreProcedure("SP_BuscarClientePorRazonSocial", parametros).Rows)
            {
                ClienteBE objCLiente = new ClienteBE();

                 objCLiente.IDCliente = Convert.ToInt32(fila["id_cliente"]);
                 objCLiente.Telefono = fila["telefono"].ToString();
                 objCLiente.Contacto = fila["contacto"].ToString();
                 objCLiente.RazonSocial = fila["razon_social"].ToString();
                 objCLiente.Cuil = fila["cuil"].ToString();
                 objCLiente.DNI = fila["dni"].ToString();
                 valoresretornados.Add(objCLiente);
            }
            return valoresretornados;

        }

       public bool ModificarCliente(ClienteBE cliente)
        {
            Conexion objconexion = Conexion.GetInstance();
            SqlParameter[] misParametros
            = {
            objconexion.crearParametro("@CUIL", cliente.Cuil),
            objconexion.crearParametro("@Dni", cliente.DNI),
            objconexion.crearParametro("@RazonSocial",cliente.RazonSocial),
            objconexion.crearParametro("@Telefono", cliente.Telefono),
            objconexion.crearParametro("@Contacto",cliente.Contacto),
            objconexion.crearParametro("@IdCliente",cliente.IDCliente)
            };

            return objconexion.EscribirPorStoreProcedure("SP_ModificarCliente", misParametros) > 0;// si hay filas afectas es verdadero



        }


        public ClienteBE BuscarPorId(int valor)
        {
     
            Conexion objConexion = Conexion.GetInstance();

            SqlParameter[] parametros =
            {
        objConexion.crearParametro("@ID", valor)
    };

            DataTable dt = objConexion.LeerPorStoreProcedure(
                "SP_BuscarClientePorID",
                parametros
            );

            if (dt.Rows.Count == 0)
                return null;

            DataRow fila = dt.Rows[0];

            ClienteBE objCliente = new ClienteBE();

            objCliente.IDCliente = Convert.ToInt32(fila["id_cliente"]);
            objCliente.Telefono = fila["telefono"].ToString();
            objCliente.Contacto = fila["contacto"].ToString();
            objCliente.RazonSocial = fila["razon_social"].ToString();
            objCliente.Cuil = fila["cuil"].ToString();
            objCliente.DNI = fila["dni"].ToString();

            return objCliente;
        }

    }
}