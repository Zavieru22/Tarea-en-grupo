/*
 * Crea una lista doble Usando como clases:
 * Domador:
 *  Atributos:
 *      Docil:  Apunta a la primera Jaula
 *      Rebelde:  Apunta al ultima Jaula
 *  Metodos:
 *      Mostrar: muestra las jaulas a partir del Rebelde al Docil
 *      Domesticar: Pide nombre y edad y agrega 1 jaula por el lado Docil
 *      MayoresA: Pide de parametro una edad y muestra los Leones 
 *          a partir de esa edad
 *      MezclaParesInicio: Pide de parametro un segundo domador y 
 *          agrega al final del Domador actual solo los leones con edad par 
 *
 * Jaula
 *  Atributos:
 *      Leon:  Apunta al primer Leon
 *      Sig:  Apunta a la siguiente Jaula
 *      Ant:  Apunta a la anterior Jaula
 *  Metodos:
 *      
 *      
 * Leon
 *  Atributos:
 *      Nombre:  Apunta al primer Leon
 *      Edad:  Apunta al ultimo Leon
 *  Metodos:
 *      ToString: muestra El nombre y Edad del Leon
 *      
 *      
 * Problema: Cree un menu donde se agreguen Jaulas (con sus leones) al 
 * cuidado de un Domador. El menu de opciones sera: 
 * 1-Agrega Domestica Leon: usa metodo Domesticar
 * 2-Muestra Leones: usa metodo Mostrar
 * 3-Muestra Leones mayores a: usa metodo MayoresA
 * 4-Mezcla: pide cuantas jaulas se agregaran a un nuevo domador y 
 *  pedira los datos de los respectivos leones y usar el metodo 
 *  MezclaParesInicio
 * 9-Salir
 */
using System;

namespace ListaDoble
{
    class Program
    {
        static void Main(string[] args)
        {
            Domador d1 = new Domador();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Agrega Domestica Leon");
                Console.WriteLine("2. Muestra Leones");
                Console.WriteLine("3. Muestra Leones mayores a");
                Console.WriteLine("4. Mezcla");
                Console.WriteLine("9. Salir");
                Console.Write("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        d1.Domesticar();
                        break;

                    case 2:
                        Console.WriteLine("\n--- LEONES ---");
                        d1.Mostrar();
                        break;

                    case 3:
                        Console.Write("Edad minima: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n--- RESULTADO ---");
                        d1.MayoresA(edad);
                        break;

                    case 4:
                        Domador d2 = new Domador();

                        Console.Write("¿Cuántas jaulas desea ingresar?: ");
                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nLeon {i + 1}");
                            d2.Domesticar();
                        }

                        Console.WriteLine("\n--- MEZCLANDO (solo edades pares) ---");
                        d1.MezclaParesInicio(d2);
                        break;

                    case 9:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 9);
        }
    }
}



