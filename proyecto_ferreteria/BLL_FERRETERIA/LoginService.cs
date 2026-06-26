using System;
using System.Data;
using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace BLL_FERRETERIA
{
    public class LoginService
    {
        private readonly LoginDatos _dal = new LoginDatos();

        private static string SafeString(DataRow row, string columnName)
        {
            if (!row.Table.Columns.Contains(columnName))
                return null;
            return row[columnName] == DBNull.Value ? null : row[columnName].ToString();
        }

        private static int SafeInt(DataRow row, string columnName, int defaultValue = 0)
        {
            if (!row.Table.Columns.Contains(columnName))
                return defaultValue;
            if (row[columnName] == DBNull.Value)
                return defaultValue;
            return Convert.ToInt32(row[columnName]);
        }

        public UsuarioBE Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("Ingrese el usuario.");

            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("Ingrese la contraseña.");

            DataTable dt = _dal.Login(usuario, clave);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new UsuarioBE
            {
                IdUsuario = SafeInt(row, "id_usuario"),
                Nombre = SafeString(row, "nombre"),
                Apellido = SafeString(row, "apellido"),
                Email = SafeString(row, "email"),
                IdPerfil = SafeInt(row, "id_perfil"),
                NombrePerfil = SafeString(row, "perfil"),
                Estado = "Activo"
            };
        }
    }
}
