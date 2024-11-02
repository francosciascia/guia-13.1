using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace _13._1
{
    internal class Denuncia : Ticket
    {
        Vehiculo dominio;
        static int numero;

        public Denuncia (Vehiculo asegurado)
        {
            dominio = asegurado;
            nroOrden = numero++;
        }
    }
}
