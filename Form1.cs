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
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        void Guardar_Datos_Clientes()
        {
            FileStream fs = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Write );
            StreamWriter sw = new StreamWriter(fs);
            foreach(var cs in clientes)
            {
                sw.WriteLine(cs.NIT1);
                sw.WriteLine(cs.Nombre1);
                sw.WriteLine(cs.Direccion1);
            }
            sw.Close();
        }

        void Leer_Datos_Clientes()
        {
            FileStream fs = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1 )
            {
                Cliente cs = new Cliente();

                cs.NIT1 = sr.ReadLine();
                cs.Nombre1 = sr.ReadLine();
                cs.Direccion1 = sr.ReadLine();

                clientes.Add(cs);
            }
            sr.Close();

            dataClientes.DataSource = null;
            dataClientes.DataSource = clientes;
            dataClientes.Refresh();
        }

       
        public Form1()
        {
            InitializeComponent();
        }
        //Trabajando Formulario Datos de Alquiler

        List<DatosDelAlquiler> Alquileres = new List<DatosDelAlquiler>();
        List<CienteAlquilerPagar> Pagos = new List<CienteAlquilerPagar>();

        private void ingresarDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosAlquiler Form = new DatosAlquiler();
            Form.Show();
            Form.Pasar_Alquiler += new DatosAlquiler.pasar_datos(ejecutar);  
        }

        public void ejecutar(string NIT,
            string Placa,
            DateTime FechaAlquiler,
            DateTime FechaDevolucion,
            float KilometrosRecorridos)
        {
            DatosDelAlquiler datos = new DatosDelAlquiler();

            datos.Nit1 = NIT;
            datos.Placa1 = Placa;
            datos.FechaAlquiler1 = FechaAlquiler;
            datos.FechaDevolucion1 = FechaDevolucion;
            datos.KilometrosRecorridos1 = KilometrosRecorridos;

            Alquileres.Add(datos);
            Guardar_Datos_Alquiler();

        }

        void Guardar_Datos_Alquiler()
        {
            FileStream fs = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var cs in Alquileres)
            {
                sw.WriteLine(cs.Nit1);
                sw.WriteLine(cs.Placa1);
                sw.WriteLine(cs.FechaAlquiler1);
                sw.WriteLine(cs.FechaDevolucion1);
                sw.WriteLine(cs.KilometrosRecorridos1);
            }
            sw.Close();
        }
        void Leer_Datos_Alquiler()
        {
            FileStream fs = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                DatosDelAlquiler da = new DatosDelAlquiler();

                da.Nit1 = sr.ReadLine();
                da.Placa1 = sr.ReadLine();
                da.FechaAlquiler1 = DateTime.Parse(sr.ReadLine());
                da.FechaDevolucion1 = DateTime.Parse(sr.ReadLine());
                da.KilometrosRecorridos1 = float.Parse(sr.ReadLine());

                Alquileres.Add(da);
            }
            sr.Close();

            dataAlquiler.DataSource = null;
            dataAlquiler.DataSource = Alquileres;
            dataAlquiler.Refresh();
        }

        // Trabajando con el Formulario Datos del Vehiculo

        List<DatosDelVehiculo> Vehiculos = new List<DatosDelVehiculo>();

        private void ingresarDatosDelVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosVehiculo Form = new DatosVehiculo();          
            Form.Show();
            Form.Pasar_Vehiculos += new DatosVehiculo.pasar_datos_vehiculos(DataVehiculo);
        }

        public void DataVehiculo(
             string Placa,
          string Marca,
          string Modelo,
          string Color,
          float precioKilometro
            )
        {
            DatosDelVehiculo data = new DatosDelVehiculo();
            data.Placa1 = Placa;
            data.Marca1 = Marca;
            data.Modelo1 = Modelo;
            data.Color1 = Color;
            data.PrecioPorKilometro1 = precioKilometro;

            Vehiculos.Add(data);
            Guardar_Datos_Vehiculos();
        }

        void Guardar_Datos_Vehiculos()
        {
            FileStream fs = new FileStream("Vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var cs in Vehiculos)
            {
                sw.WriteLine(cs.Placa1);
                sw.WriteLine(cs.Marca1);
                sw.WriteLine(cs.Modelo1);
                sw.WriteLine(cs.Color1);
                sw.WriteLine(cs.PrecioPorKilometro1);
            }
            sw.Close();
        }
        void Leer_Datos_Vehiculos()
        {
            FileStream fs = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                DatosDelVehiculo da = new DatosDelVehiculo();

                da.Placa1 = sr.ReadLine();
                da.Marca1 = sr.ReadLine();
                da.Modelo1 = sr.ReadLine();
                da.Color1= sr.ReadLine();
                da.PrecioPorKilometro1 = float.Parse(sr.ReadLine());

                Vehiculos.Add(da);
            }
            sr.Close();
            dataVehiculos.DataSource = null;
            dataVehiculos.DataSource = Vehiculos;
            dataVehiculos.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Cliente agregar = new Cliente();
            if (texNIT.Text == "" || texNombre.Text == "" || texDirección.Text == "")
            {
                MessageBox.Show("Llenar todos los campos de texto para agregar al cliente");
            }
            else
            {
                agregar.NIT1 = texNIT.Text;
                agregar.Nombre1 = texNombre.Text;
                agregar.Direccion1 = texDirección.Text;
                texNIT.Text = "";
                texNombre.Text = "";
                texDirección.Text = "";
                clientes.Add(agregar);
                Guardar_Datos_Clientes();
                //Leer_Datos_Clientes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Leer_Datos_Clientes();
            Leer_Datos_Alquiler();
            Leer_Datos_Vehiculos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataClientes.DataSource = null;
            dataClientes.DataSource = clientes;
            dataClientes.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataAlquiler.DataSource = null;
            dataAlquiler.DataSource = Alquileres;
            dataAlquiler.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataVehiculos.DataSource = null;
            dataVehiculos.DataSource = Vehiculos;
            dataVehiculos.Refresh();
        }
    }
}
