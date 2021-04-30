using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Teclado
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string formato { get; set; }
        public Boolean pad { get; set; }

        public Teclado(string marca, string modelo, string formato, string pad)
        {
            marca = marca;
            modelo = modelo;
            pad = pad;
            formato = formato;
        }
    }
}
