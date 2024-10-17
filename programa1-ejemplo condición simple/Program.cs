using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1_ejemplo_condición_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que te avisa si la frecuencia es muy alta (arriba de 60)
            int Fre;
            Console.Write("¿Cual es la frecuencia?: ");
            Fre = Int32.Parse(Console.ReadLine());
            if (Fre > 60)
            {
                Console.WriteLine("La frecuencia es demasiado alta");
            }
            Console.WriteLine("Pulsar enter para salir del programa");
            Console.ReadKey();
        }
    }
}
