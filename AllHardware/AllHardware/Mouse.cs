using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Mouse
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public Boolean inalambrico { get; set; }
        public string rangomax { get; set; }
        public int dpi

        public Mouse(string marca, string modelo, Boolean inalambrico, string rangomax, int dpi)
        {
            marca = marca;
            modelo = modelo;
            inalambrico = inalambrico;
            rangomax = rangomax;
            dpi = dpi;

        }
    }
}
