using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Fuente_Poder
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int watts { get; set; }

        public Fuente_Poder(string marca, string modelo, int watts)
        {
            marca = marca;
            modelo = modelo;
            watts = watts;
        }
    }
}
