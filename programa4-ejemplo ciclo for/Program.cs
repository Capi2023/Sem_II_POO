using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa4_ejemplo_ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, C = 0;

            Console.Write("¿Que tabla de mutliplicar deseas?: ");
            N = Int32.Parse(Console.ReadLine());

            for (C = 1; C <= 12; C++)
            {
                int F = 0;
                F = N * C;
                Console.WriteLine(C + " * " + N + " = " + F + "\r");
            }
            Console.WriteLine("Presione enter para cerrar programa");
            Console.ReadKey();
        }
    }
}
