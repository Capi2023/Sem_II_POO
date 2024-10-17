using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa11_ejemplo_arreglo_bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 0, C = 0;

            //Declaracion de arreglos bidimensionales
            int[,] Num = new int[4, 4];

            //Generador de numeros aleatorios
            Random alea = new Random();

            //Ciclo for para leer los numeros
            for (R = 0; R < 4; R++)
            {
                for (C = 0; C < 4; C++)
                {
                    Num[R, C] = alea.Next(50);
                }
            }

            //Impresion de numeros en tabla de numeros
            Console.WriteLine("Impresion de numeros aleatorios");
            for (R = 0; R < 4; R++)
            {
                for (C = 0; C < 4; C++)
                {
                    Console.Write(Num[R, C] + "\t");
                }
                Console.Write("\r\n");
            }

            //Impresion de numeros en Diagonal central
            Console.WriteLine("Imprersion de numeros en diagonal");
            for (R = 0; R < 4; R++)
            {
                Console.WriteLine(Num[R, R]);
            }

            //Impresion de numeros en Renglon 2
            Console.WriteLine("Imprersion de numeros del rengol 2");
            for (R = 0; R < 4; R++)
            {
                Console.WriteLine(Num[1, R]);
            }

            //Impresion de numeros en Columna 3
            Console.WriteLine("Imprersion de numeros en la columna 3");
            for (R = 0; R < 4; R++)
            {
                Console.WriteLine(Num[R, 2]);
            }

            Console.WriteLine("Pulsa enter para salir del programa");
            Console.ReadKey();
        }
    }
}
