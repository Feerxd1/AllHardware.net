using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class hdd
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Capacidad { get; set; }
        public string Compatibilidad { get; set; }

        public hdd(string marca, string modelo, double capacidad, string compatibilidad)
        {
            marca = marca;
            modelo = modelo;
            capacidad = capacidad;
            compatibilidad = compatibilidad;
        }
    }
}
