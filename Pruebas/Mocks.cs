using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_DPS1
{
    public class ConexionDBMock : ConexionBD
    {
        public bool wasCalled;
        public int numberOfCalls;

        public ConexionDBMock()
        {
            this.wasCalled = false;
            this.numberOfCalls = 0;
        }

        public object[] Select(string query)
        {
            this.wasCalled = true;
            this.numberOfCalls += 1;
            return new object[] {};
        }
    }
}
