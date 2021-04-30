using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class ram
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string compatibilidad { get; set; }
        public string capacidad { get; set; }
        public string formato { get; set; }

        public ram (string marca, string modelo, string compatibilidad, string capacidad, string formato)
        {
            marca = marca;
            modelo = modelo;
            compatibilidad = compatibilidad;
            capacidad = capacidad;
            formato = formato;
        }
    }
}
