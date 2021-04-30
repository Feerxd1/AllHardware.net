using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Procesador
    {
        public string modelo { get; set; }
        public string zocalo { get; set; }
        public int nucleos { get; set; }
        public int hilos { get; set; }
        public string frecuencia { get; set; }

        public Procesador(string modelo, string zocalo, int nucleos, int hilos, string frecuencia)
        {
            modelo = modelo;
            zocalo = zocalo;
            nucleos = nucleos;
            hilos = hilos;
            frecuencia = frecuencia;
        }
    }
}
