using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_FERRETERIA
{
    public class Autenticador
    {
        public Rol Validar(string usuario, string clave)
        {
            if (usuario == "gerente" && clave == "1234")
                return Rol.Gerente;

            if (usuario == "vendedor" && clave == "1234")
                return Rol.Vendedor;

            if (usuario == "logistica" && clave == "1234")
                return Rol.Logistica;

            if (usuario == "sistema" && clave == "1234")
                return Rol.Sistema;

            return Rol.Ninguno;
        }


    }
}
