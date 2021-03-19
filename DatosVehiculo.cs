using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Repaso2
{
    public partial class DatosVehiculo : Form
    {
        public delegate void pasar_datos_vehiculos(
          string Placa,
          string Marca,
          string Modelo,
          string Color,
          float precioKilometro
          );

        public event pasar_datos_vehiculos Pasar_Vehiculos;
        public DatosVehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texPlaca.Text == "" || texMarca.Text == "" || texModelo.Text == "" || texColor.Text == "" || texPrecKilo.Text == "")
            {
                MessageBox.Show("Llenar todos los campos para que se agreguen los datos");
            }
            else
            {
                Pasar_Vehiculos
                    (
                    texPlaca.Text,
                    texMarca.Text,
                    texModelo.Text,
                    texColor.Text,
                    float.Parse(texPrecKilo.Text)
                    );
                texPlaca.Text = "";
                texMarca.Text = "";
                texModelo.Text = "";
                texColor.Text = "";
                texPrecKilo.Text = "";
            }
        }
    }
}
