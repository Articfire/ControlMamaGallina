using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_DPS1
{
    public class ConexionDBMock
    {
        bool wasCalled;
        int numberOfCalls;

        public ConexionDBMock()
        {
            this.wasCalled = true;
            this.numberOfCalls = 0;
        }

        public static object[] Seleccionar(string query)
        {
            return new object[] {};
        }
    }
}
