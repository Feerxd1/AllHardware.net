using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Gabinete
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public string tamaño { get; set; }

        public Gabinete(string marca, string modelo, string color, string tamaño)
        {
            marca = marca;
            modelo = modelo;
            color = color;
            tamaño = tamaño;
        }
    }
}
