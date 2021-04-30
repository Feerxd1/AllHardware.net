using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Disipador
    {
        public string marca { get; set; }
        public string modelo { get; set; } 
        public int socket { get; set; }
        public int RPM { get; set; }

        public Disipador(string marca, string modelo, int socket, int RPM)
        {
            marca = marca;
            modelo = modelo;
            socket = socket;
            RPM = RPM;
        }
    }
}
