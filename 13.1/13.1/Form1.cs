using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace _13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Agencia a = new Agencia();
        Ticket t = new Denuncia(new Vehiculo("Hola", new Cliente("1234")));
        Ticket c = new Cliente("1234");
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
           saveFileDialog1.Filter = "Archivos .csv |*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

                string path = saveFileDialog1.FileName;

                FileStream fs = null;
                StreamWriter sw = null;

                a = new Agencia();
                a.ListaAtendidos.Add(t);
                a.ListaAtendidos.Add(c);
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (Ticket t in a.ListaAtendidos)
                    {
                        if (t is Denuncia)
                        {
                            Denuncia d = (Denuncia)t;
                            sw.WriteLine($"{d.VerNro()};Denuncia");
                        }
                        if (t is Cliente)
                        {
                            Cliente c = (Cliente)t;
                            sw.WriteLine($"{c.VerNro()};Cliente");
                        }
                    }
                }

                catch (Exception ex) { }
                finally
                {
                    if (sw != null) { sw.Close(); }
                    if (fs != null) { fs.Close(); }
                }

            }
        }
            

        private void tbDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                FileStream fs = null;
                string path = openFileDialog1.FileName;

                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    string linea = sr.ReadLine();
                    while (linea != null)
                    {
                        linea = sr.ReadLine();
                        string[] campos = linea.Split(';');


                    }
                }
                catch { }
            }
        }
    }
}
