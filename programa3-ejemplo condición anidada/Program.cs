using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3_ejemplo_condición_anidada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que te avisa si tu numero es psotivo o negativo o igaul a cero
            int Num;
            Console.Write("¿Cual es tu numero?: ");
            Num = Int32.Parse(Console.ReadLine());

            if (Num == 0)
            {
                Console.WriteLine("El numero " + Num + " es igual a cero");
            }
            else if (Num > 0)
            {
                Console.WriteLine("El numero " + Num + " es positivo");
            }
            else
            {
                Console.WriteLine("El numero " + Num + " es negativo");
            }
            Console.WriteLine("Pulsa enter para salir del programa");
            Console.ReadKey();
        }
    }
}
