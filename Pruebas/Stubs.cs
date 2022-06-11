using System;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public class LoginStubs
    {
        public object[] Seleccionar(string query)
        {
            return new object[3] {"adminm", "1410", "Administrador" };
        }

        public bool isUserLoginValid(object[] resultados, string user_field, string password_field)
        {
            return true;
        }
    }
}
