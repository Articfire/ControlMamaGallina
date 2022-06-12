using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public class Tests
    {
        LoginStubs login_stubs;
        CorteStubs corte_stubs;
        ConexionDBMocks db_mocks;
        ConexionBD bd;

        [SetUp]
        public void Setup()
        {
            login_stubs = new LoginStubs();
            corte_stubs = new CorteStubs();
            db_mocks = new ConexionDBMocks();
            bd = new ConexionBD();
        }

        // Pruebas unitarias de Stubs

        [Test]
        public void Seleccionar_returns_object_array()
        {
            // Arrange
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = 'adminm'";

            // Act
            object[] resultados = bd.Seleccionar(query);

            // Assert
            Assert.AreEqual(resultados.GetType(), login_stubs.loginSeleccionar(query).GetType());
        }

        [Test]
        public void isUserLoginValid_returns_boolean()
        {
            // Arrange
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = 'adminm'";
            // Act
            bool isValid = login_stubs.isUserLoginValid(login_stubs.loginSeleccionar(query), "adminm", "1410");
            // Assert
            Assert.AreEqual(true, isValid);
        }

        [Test]
        public void aceptarCorteDiario_returns_double()
        {
            // Arrange
            double corte;
            // Act
            corte = corte_stubs.aceptarCorteDiario();
            // Assert
            Assert.AreEqual(0.0, corte);
        }

        // Pruebas unitarias de Mocks

        [Test]
        public void Seleccionar_was_called()
        {
            // Arrange
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = 'adminm'";
            // Act
            db_mocks.Seleccionar(query);
            // Assert
            Assert.IsTrue(db_mocks.SeleccionarWasCalled);
            Assert.Greater(db_mocks.numberOfCalls, 0);
        }

        [Test]
        public void SqlConnection_works()
        {
            // Arrange
            // Act
            db_mocks.Abrir();
            // Assert
            Assert.AreEqual(ConnectionState.Open, db_mocks.conn.State);
        }

        [Test]
        public void SqlConnection_can_be_closed()
        {
            // Arrange
            // Act
            db_mocks.Cerrar();
            // Assert
            Assert.AreEqual(ConnectionState.Closed, db_mocks.conn.State);
        }
    }
}
