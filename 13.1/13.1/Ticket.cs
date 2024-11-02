using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace _13._1
{
    internal abstract class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public abstract int VerNro();
        public abstract DateTime VerFechaHora();
    }
}
