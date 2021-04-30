using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Ventilador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string rpm { get; set; }


        public Ventilador(string marca, string modelo, string rpm)
        {
            marca = marca;
            modelo = modelo;
            rpm = rpm

        }
    }
}
