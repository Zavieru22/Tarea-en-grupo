using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListaDoble.Leon;

namespace ListaDoble
{
    public class Jaula
    {
        public Leon Leon { get; set; }
        public Jaula Sig { get; set; }
        public Jaula Ant { get; set; }

        public Jaula(Leon leon)
        {
            Leon = leon;
            Sig = null;
            Ant = null;
        }
    }
}