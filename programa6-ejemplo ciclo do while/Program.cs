using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa6_ejemplo_ciclo_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 0, Num = 0, NumM = 0, NumT = 1;
            Console.Write("Que numero deseas obtener: ");
            Num = Int32.Parse(Console.ReadLine());

            //Condicion para saber si el numero es positivo
            if (Num > 0)
            {
                //Proceso do while para imprimir el proceso y resultado del factorial
                Console.WriteLine("Proceso factorial");
                do
                {
                    NumM = Num - C;
                    Console.WriteLine(NumM);
                    C = C + 1;
                    NumT = NumM * NumT;
                }
                while (C < Num);
            }

            else
            {
                //Mostrar que no es positivo y limpiar txtNum
                Console.WriteLine("No es un numero positivo");
            }
            //Imprimir resultado factorial
            Console.WriteLine("Resultado final: " + NumT);
            Console.WriteLine("Pulsa enter para cerrar el programa");
            Console.ReadKey();
        }
    }
}
