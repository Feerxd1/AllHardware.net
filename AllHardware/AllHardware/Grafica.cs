using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class grafica
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tipomemoria { get; set; }
        public string capacidadmemoria { get; set; }

        public grafica(string marca, string modelo, string tipomemoria, string capacidadmemoria)
        {
            marca = marca;
            modelo = modelo;
            tipomemoria = tipomemoria;
            capacidadmemoria = capacidadmemoria;
        }
    }
}
