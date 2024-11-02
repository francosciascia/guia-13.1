using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace _13._1
{
    internal class NuevaExcepcion : Exception
    {
        public NuevaExcepcion(string mensaje)  : base (mensaje){ }
    }
}
