using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES.FERRETERIA; //referecia a la capa de entidades para usar el enum TipoUsuario

namespace BLL_FERRETERIA
{
    public class UsuarioFactory
    {
        public UsuarioFactory()
        { 
        }

        public Usuario CrearUsuario(TipoUsuario tipo, int idUsuario, string nombreUsuario,string clave,string nombre,string apellido)
        {
            switch (tipo)
            {
                case TipoUsuario.Administrador:
                    return new Administrador(idUsuario, nombreUsuario, clave, nombre, apellido);

                case TipoUsuario.Vendedor:
                    return new Vendedor(idUsuario, nombreUsuario, clave, nombre, apellido);

                case TipoUsuario.Gerente:
                    return new Gerente(idUsuario, nombreUsuario, clave, nombre, apellido);

                case TipoUsuario.EncargadoDeposito:
                    return new EncargadoDeposito(idUsuario, nombreUsuario, clave, nombre, apellido);

                default:
                    throw new Exception("Tipo de usuario inválido");
            }
        }

    }
}
