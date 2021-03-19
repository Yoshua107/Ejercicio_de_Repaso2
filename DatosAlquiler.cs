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

namespace Ejercicio_de_Repaso2
{
    public partial class DatosAlquiler : Form
    {
       
        public delegate void pasar_datos(
            string NIT, 
            string Placa, 
            DateTime FechaAlquiler,
            DateTime FechaDevolucion,
            float KilometrosRecorridos
            );

        public event pasar_datos Pasar_Alquiler;

        public DatosAlquiler()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
           
            if (texNITAlquiler.Text == "" || texPlacaAlquiler.Text == "" ||texKlmRecorridos.Text == "" || dateTimeAlquiler.Value == DateTime.Now || dateTimeDevolucion.Value == DateTime.Now)
            {
                MessageBox.Show("Llenar todos los campos de texto para agregar los datos");
            }
            else
            {

                Pasar_Alquiler(
                    texNITAlquiler.Text,
                    texPlacaAlquiler.Text,
                    dateTimeAlquiler.Value,
                    dateTimeDevolucion.Value,
                    float.Parse(texKlmRecorridos.Text)
                    );

                texNITAlquiler.Text = "";
                texPlacaAlquiler.Text = "";
                dateTimeAlquiler.Value = DateTime.Now;
                dateTimeDevolucion.Value = DateTime.Now;
                texKlmRecorridos.Text = "";
            }
        }
    }
}
