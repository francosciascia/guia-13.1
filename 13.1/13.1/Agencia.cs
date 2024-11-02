using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace _13._1
{
    internal class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();

        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        
        
        public void AgregarTicket (Ticket turno)
        {
            ListaAtendidos.Add(turno);
        }
        
        
    }
}
