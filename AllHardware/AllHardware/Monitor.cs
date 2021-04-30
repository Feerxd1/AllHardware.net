using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Monitor
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tamaño_Pantalla { get; set; }
        public string Tipo_Pantalla { get; set; }

        public Monitor(string marca, string modelo, string tamaño_Pantalla, string tipo_Pantalla)
        {
            marca = marca;
            modelo = modelo;
            tamaño_Pantalla = tamaño_Pantalla;
            tipo_Pantalla = tipo_Pantalla;
        }
    }
}
