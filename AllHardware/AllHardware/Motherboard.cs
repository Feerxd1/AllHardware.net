using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Motherboard
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string factor_forma { get; set; }
        public int slots_Ram { get; set; }
        public int socket { get; set; }
        public string ranuras_expansion { get; set; }
        public int cantidad_sata { get; set; }
        public int cantidad_usb { get; set; }

        public Motherboard(string nombre, string tipo, string factor_Forma, int slots_ram, 
            int socket, string ranuras_expansion, int cantidad_sata, int cantidad_usb)
        {
            nombre = nombre;
            tipo = tipo;
            factor_Forma = factor_Forma;
            slots_ram = slots_ram;
            socket = socket;
            ranuras_Expansion = ranuras_expansion;
            cantidad_sata = cantidad_Sata;
            cantidad_usb = cantidad_usb;
        }
    }
}
