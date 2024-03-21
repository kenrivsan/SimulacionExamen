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
        List<clsNombreTemp> temperatura2 = new List<clsNombreTemp>();
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
        }

        private void btnIngresarTemp_Click(object sender, EventArgs e)
        {
            clsTemperatura temperaturas = new clsTemperatura();
            temperaturas.NoIdentificacion = int.Parse(txtNoidentificacion.Text);
            temperaturas.Temperatura = decimal.Parse(txtTemp.Text);
            temperatura.Add(temperaturas);
            guardarTemp();
            mostrarTemp();
            limpieza2();
        }
        void limpieza2()
        {
            txtNomDep.Clear();
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
            dtvDepartamentos.DataSource = null;
            dtvDepartamentos.DataSource = departamento;
            dtvDepartamentos.Refresh();
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
            dtvTemperaturas.DataSource = null;
            dtvTemperaturas.DataSource = temperatura;
            dtvTemperaturas.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (clsDepartamento departamentos in departamento)
            {
                clsTemperatura temp = temperatura.FirstOrDefault(p => p.NoIdentificacion == departamentos.NoIdentificacion);
                if(temperatura != null)
                {
                    clsNombreTemp reporte = new clsNombreTemp
                    {
                        Nombre = departamentos.Nombre,
                        Temperatura = temp.Temperatura,
                        
                    };
                    temperatura2.Add(reporte);
                }
            }
            dtvNomTemp.DataSource = null;
            dtvNomTemp.DataSource = temperatura2;
            dtvNomTemp.Refresh();
        }
    }
}
