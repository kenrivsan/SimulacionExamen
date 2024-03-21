using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SimulacionExamen
{
    
    public partial class Form1 : Form
    {
        List<clsDepartamento> departamento = new List<clsDepartamento>();
        List<clsTemperatura> temperatura = new List<clsTemperatura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarDep_Click(object sender, EventArgs e)
        {
            clsDepartamento departamentos = new clsDepartamento();
            departamentos.NoIdentificacion = int.Parse(txtNoidentificacion.Text);
            departamentos.Nombre = txtNomDep.Text;
            departamento.Add(departamentos);
            guardarDep();
            mostrarDep();
            limpieza();
        }
        void limpieza()
        {
            txtNoidentificacion.Clear();
            txtNomDep.Clear();
            txtNoidentificacion.Focus();
        }
        private void btnIngresarTemp_Click(object sender, EventArgs e)
        {
            clsTemperatura temperaturas = new clsTemperatura();
            temperaturas.NoIdentificacion = int.Parse(txtNoidentificacion.Text);
            temperaturas.Temperatura = decimal.Parse(txtTemp.Text);
            temperatura.Add(temperaturas);
            guardarTemp();
            mostrarTemp();
        }
        void limpieza2()
        {
            txtNoidentificacion.Clear();
            txtTemp.Clear();
            txtNoidentificacion.Focus();
        }
        public void guardarDep()
        {
            using (FileStream stream = new FileStream("Departamentos.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (clsDepartamento departamentoss in departamento)
                    {
                        writer.WriteLine(departamentoss.NoIdentificacion);
                        writer.WriteLine(departamentoss.Nombre);
                    }
                    writer.Close();
                }
            }
        }
        void mostrarDep()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = departamento;
            dataGridView1.Refresh();
        }
        public void guardarTemp()
        {
            using (FileStream stream = new FileStream("Temperaturas.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (clsTemperatura temperaturass in temperatura)
                    {
                        writer.WriteLine(temperaturass.NoIdentificacion);
                        writer.WriteLine(temperaturass.Temperatura);
                    }
                    writer.Close();
                }
            }
        }
        void mostrarTemp()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = temperatura;
            dataGridView2.Refresh();
        }
    }
}
