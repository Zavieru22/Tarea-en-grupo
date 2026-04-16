using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListaDoble.Jaula;
using static ListaDoble.Leon;

namespace ListaDoble
{
    public class Domador
    {
        public Jaula Docil { get; set; }
        public Jaula Rebelde { get; set; }

        public void Mostrar()
        {
            Jaula actual = Rebelde;

            while (actual != null)
            {
                Console.WriteLine(actual.Leon);
                actual = actual.Ant;
            }
        }

        public void Domesticar()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Jaula nueva = new Jaula(new Leon(nombre, edad));

            if (Docil == null)
            {
                Docil = Rebelde = nueva;
            }
            else
            {
                nueva.Sig = Docil;
                Docil.Ant = nueva;
                Docil = nueva;
            }
        }

        public void MayoresA(int edad)
        {
            Jaula actual = Docil;

            while (actual != null)
            {
                if (actual.Leon != null && actual.Leon.Edad >= edad)
                {
                    Console.WriteLine(actual.Leon);
                }
                actual = actual.Sig;
            }
        }

        public void MezclaParesInicio(Domador otro)
        {
            Jaula actual = otro.Docil;

            while (actual != null)
            {
                if (actual.Leon != null && actual.Leon.Edad % 2 == 0)
                {
                    Jaula nueva = new Jaula(
                        new Leon(actual.Leon.Nombre, actual.Leon.Edad)
                    );

                    if (Rebelde == null)
                    {
                        Docil = Rebelde = nueva;
                    }
                    else
                    {
                        nueva.Ant = Rebelde;
                        Rebelde.Sig = nueva;
                        Rebelde = nueva;
                    }
                }

                actual = actual.Sig;
            }
        }
    }
}
