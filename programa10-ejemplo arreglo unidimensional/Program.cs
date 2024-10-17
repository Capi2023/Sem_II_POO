using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa10_ejemplo_arreglo_unidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int[] Num;
            int A = 0, B = 0, Temp = 0, R = 0, Medi = 0;

            //Creacion de referencia de arreglo
            Num = new int[10];

            //Creacion de random
            Random alea = new Random();

            Console.WriteLine("Creacion de numeros aleatoriamente");

            //Ciclo for para crear numeros aleatorios
            for (R = 0; R < 10; R++)
            {
                Num[R] = alea.Next(100);
                Console.WriteLine(Num[R]);
            }

            Console.WriteLine("Pulsa enter para ordenar los numeros de menor a mayor");
            Console.ReadKey();
            //Ciclo for para ordenamiento burbuja
            for (A = 1; A <= 10; A++)
            {
                for (B = 10 - 1; B >= A; B--)
                {
                    if (Num[B - 1] > Num[B])
                    {
                        Temp = Num[B - 1];
                        Num[B - 1] = Num[B];
                        Num[B] = Temp;
                    }
                }
            }

            //Impresion de numeros en orden ascendente
            for (R = 0; R < 10; R++)
            {
                Console.WriteLine(Num[R]);
            }

            //Calculo e impresion de la mediana
            Console.WriteLine("Pulsa enter para calcular la mediana");
            Console.ReadKey();
            Medi = (Num[4] + Num[5]) / 2;
            Console.WriteLine(Medi);

            Console.WriteLine("Pulsa enter para cerrar programa");
            Console.ReadKey();
        }
    }
}
