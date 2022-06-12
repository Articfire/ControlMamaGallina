using System.Data;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public class ConexionDBMocks : ConexionBD
    {
        public bool AbrirWasCalled;
        public bool CerrarWasCalled;
        public bool SeleccionarWasCalled;
        public int numberOfCalls;
        public SqlConnection conn;
        public ConnectionState conn_state;
        public string connectionString;

        public ConexionDBMocks()
        {
            AbrirWasCalled = false;
            CerrarWasCalled = false;
            SeleccionarWasCalled = false;
            numberOfCalls = 0;
            connectionString = "Data Source=DESKTOP-MGAVK7S\\SQLSERVEREXPRESS;" +
                                "Initial Catalog = ControlMamaGallina;" +
                                "User ID = sa;" +
                                "Password = controlmamagallina";
            conn = new SqlConnection(connectionString);

        }

        public void Abrir()
        {
            AbrirWasCalled = true;
            numberOfCalls += 1;
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public void Cerrar()
        {
            CerrarWasCalled = true;
            numberOfCalls += 1;
            conn.Close();
        }

        public object[] Seleccionar(string query)
        {
            this.SeleccionarWasCalled = true;
            this.numberOfCalls += 1;
            return new object[] {};
        }
    }
}
