using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Repaso2
{
    class DatosDelAlquiler
    {
        string Nit;
        string Placa;
        DateTime FechaAlquiler;
        DateTime FechaDevolucion;
        float KilometrosRecorridos;

        public string Nit1 { get => Nit; set => Nit = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public DateTime FechaAlquiler1 { get => FechaAlquiler; set => FechaAlquiler = value; }
        public DateTime FechaDevolucion1 { get => FechaDevolucion; set => FechaDevolucion = value; }
        public float KilometrosRecorridos1 { get => KilometrosRecorridos; set => KilometrosRecorridos = value; }
    }
}
