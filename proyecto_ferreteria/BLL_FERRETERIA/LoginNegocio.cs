using System.Data;
using DAL_FERRETERIA;

namespace BLL_FERRETERIA
{
    public class LoginNegocio
    {
        private readonly LoginDatos _datos = new LoginDatos();

        public DataTable Login(string usuario, string clave)
        {
            return _datos.Login(usuario, clave);
        }
    }
}
