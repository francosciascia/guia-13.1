using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _13._1
{
    internal class Vehiculo
    {
        string nroPatente;
        Cliente dueño;

        public Vehiculo (string patente, Cliente dueño)
        {
            nroPatente = patente;
            this.dueño = dueño;
        }

        public Cliente VerDueño()
        {
            return dueño;
        }

        private string VerPatente()
        {
            return nroPatente;
        }
    }
}
