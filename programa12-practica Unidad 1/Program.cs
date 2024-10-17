using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa12_practica_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opc;
            float L;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que siguente procedimiento desea hacer?");
                Console.WriteLine("a. Calcular el area de un cubo");
                Console.WriteLine("b. Desplegar los múltiplos de 3 entre 1 y 50 utilizando los 3 ciclos");
                Console.WriteLine("c. Generar un arreglo bidimensional de 3X3 con números enteros, sacar la suma y promedio de ellos");
                Console.WriteLine("d. Salir del programa");
                opc = Char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'a':
                        Console.Write("Cual es el valor del lado: ");
                        L = Single.Parse(Console.ReadLine());
                        A(L);
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'b':
                        B();
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'c':
                        C();
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'd':
                        break;
                    default:
                        Console.WriteLine("La opcion " + opc + " no es una opcion valida");
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opc != 'd');
            Console.Write("Pulse enter para salir del programa");
            Console.ReadKey();
        }

        static void A(double LL)
        {
            double Area;
            Area = (6 * Math.Pow(LL, 2));
            Console.WriteLine("El area del cubo es de: " + Area);
        }

        static void B()
        {
            int F3, D3, W3;
            F3 = 0;
            D3 = 0;
            W3 = 0;
            //Ciclo for
            Console.WriteLine("Ciclo For");
            for (F3 = 3; F3 <= 50; F3 += 3)
            {
                Console.WriteLine(F3);
            }

            //Ciclo do while
            Console.WriteLine("Ciclo Do While");
            do
            {
                D3 = D3 + 3;
                Console.WriteLine(D3);
            } while (D3 < 48);

            //Ciclo while
            Console.WriteLine("Ciclo While");
            while (W3 < 48)
            {
                W3 = W3 + 3;
                Console.WriteLine(W3);
            }
        }
        static void C()
        {
            int R = 0, C = 0, Suma = 0, Prom = 0;

            //Declaracion de arreglos bidimensionales
            int[,] Num = new int[3, 3];

            //Generador de numeros aleatorios
            Random alea = new Random();

            //Ciclo for para leer los numeros
            for (R = 0; R < 3; R++)
            {
                for (C = 0; C < 3; C++)
                {
                    Num[R, C] = alea.Next(10, 99);
                    Suma = Suma + Num[R, C];
                }
            }

            //Impresion de numeros en tabla de numeros
            Console.WriteLine("Impresion de numeros aleatorios");
            for (R = 0; R < 3; R++)
            {
                for (C = 0; C < 3; C++)
                {
                    Console.Write(Num[R, C] + "\t");
                }
                Console.Write("\r\n");
            }
            //Promedio
            Prom = Suma / 9;

            //Suma
            Console.WriteLine("La suma de los numeros es: " + Suma);
            Console.WriteLine("El promedio de los numeros es de: " + Prom);
        }
    }
}
