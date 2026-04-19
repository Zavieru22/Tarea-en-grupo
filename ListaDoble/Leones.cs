using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoble
{
    public class Leon
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Leon(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Edad: " + Edad;
        }
    }
}