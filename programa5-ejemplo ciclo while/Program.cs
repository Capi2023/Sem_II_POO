using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa5_ejemplo_ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sal = 1000, Com = 0;
            string R1;

            Console.WriteLine("Presione P para continuar");
            R1 = Console.ReadLine();

            //Ciclo para determinar el saldo
            while (Sal != 0 && R1 == "P")
            {
                //Imprimir Sal
                Console.WriteLine("Su saldo es de: " + Sal);

                Console.WriteLine("¿Quiere seguir comprando?");
                Console.WriteLine("Pulse P si quiere comprar");
                Console.WriteLine("Pulse cualquier otra letra si no quiere");
                R1 = Console.ReadLine();
                if (R1 == "P")
                {
                    Console.Write("¿Cuanto quiere gastar?: ");
                    Com = Int32.Parse(Console.ReadLine());

                    //Condicion para saber si es suficiente el saldo
                    if (Com > Sal)
                    {
                        Console.WriteLine("Su saldo es insuficiente, se cancelo la compra");
                    }

                    else
                    {
                        Sal = Sal - Com;
                        Console.WriteLine("Su compra se realizo con exito, su saldo es de: " + Sal);
                    }
                }
            }
            //Impresion de ultimo resutlado
            Console.WriteLine("Saldo final: " + Sal);
            Console.WriteLine("Pusla enter para cerrar el programa");
            Console.ReadKey();
        }
    }
}
