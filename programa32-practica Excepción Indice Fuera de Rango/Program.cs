using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa32_practica_Excepción_Indice_Fuera_de_Rango
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int [10];
            int C;

            Random alea = new Random();

            try
            {
                for (C = 0; C < 10; C++)
                {
                    arreglo[C] = alea.Next(10, 99);
                }
                Array.Sort(arreglo);

                Console.WriteLine("Pusla enter para desplegar los numeros");
                Console.ReadKey();

                for (C = 0; C < 10; C++)
                {
                    Console.WriteLine("La posicion "+ C + " tiene el valor de "+ arreglo[C]);
                }

                Console.WriteLine("Pulsa enter para introducir el error");
                Console.ReadKey();

                arreglo[15] = 12345;
            }

            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine("\nMensaje del Error: " + a.Message);
                Console.WriteLine("\nRuta del Error: " + a.StackTrace);
                Console.Write("\nPresione <enter> para continuar."); Console.ReadKey();
            }

        }
    }
}
