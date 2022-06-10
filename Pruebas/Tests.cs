using NUnit.Framework;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Seleccionar_returns_object_array()
        {
            // Arrange
            ConexionBD bd = new ConexionBD();
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = 'adminm'";
            object[] empty_array = new object[] {};
            // Act
            object[] resultados = bd.Seleccionar(query);
            //object[] resultados = stubs.Seleccionar(query);
            // Assert
            Assert.AreEqual(resultados.GetType(), empty_array.GetType());
        }

        [Test]
        public void isUserLoginValid_returns_boolean()
        {
            // Arrange
            LoginStubs login_stubs = new LoginStubs();
            ConexionBD bd = new ConexionBD();
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = 'adminm'";
            // Act
            bool isValid = login_stubs.isUserLoginValid(bd.Seleccionar(query), "adminm", "1410");
            // Assert
            Assert.AreEqual(true, isValid);
        }
    }
}
