using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace _13._1
{
    internal class Cliente : Ticket
    {
        long dni;
        static int numero;

        public Cliente (string dni)
        {
            this.dni = Convert.ToInt16(dni);
        }

        public override int VerNro()
        {
            return 1234;
        }

        public override DateTime VerFechaHora()
        {
            return DateTime.Now;
        }
    }
}
