using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCordero_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Porgrama que despliega los números impares entre 50 y 99
            char ciclo;
            do
            {
                Console.Clear();
                Console.WriteLine("Porgrama que despliega los números impares entre 50 y 99");
                Console.WriteLine("¿Como quiere que se despliegue los numeros impares?");
                Console.WriteLine("a. Utilizando el ciclo For");
                Console.WriteLine("b. Utilizando el ciclo While");
                Console.WriteLine("c. Utilizando el cilco Do-While");
                Console.WriteLine("d. Salir del programa");

                ciclo = Char.Parse(Console.ReadLine());

                switch (ciclo)
                {
                    case 'a':
                        A();
                        Console.WriteLine("Pusle enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'b':
                        B();
                        Console.WriteLine("Pulse enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'c':
                        C();
                        Console.WriteLine("Pulse enter para continuar");
                        Console.ReadLine();
                        break;
                    case 'd':
                        break;
                    default:
                        Console.WriteLine("La opcion " + ciclo + " no es una opcion valida");
                        Console.WriteLine("Pusle enter para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (ciclo != 'd');
            Console.Write("Pulse enter para salir del programa");
            Console.ReadKey();
        }

        static void A()
        {
            int IF;
            Console.WriteLine("Ciclo For de numeros impares del 50 al 99");
            for ( IF = 51; IF <= 99; IF+=2)
            {
                Console.WriteLine(IF);
            }
        }

        static void B()
        {
            int IW = 51;
            Console.WriteLine("Ciclo While de numeros impares del 50 al 99");
            while (IW <= 99)
            {
                Console.WriteLine(IW);
                IW = IW + 2;
            }
        }

        static void C()
        {
            int ID = 51;
            Console.WriteLine("Ciclo Do-While de numeros impares del 50 al 99");
            do
            {
                Console.WriteLine(ID);
                ID = ID + 2;
            } while (ID <= 99);
        }
    }
}
