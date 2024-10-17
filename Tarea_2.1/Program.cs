using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1
{
    class Program
    {
        public class Numeros
        {
            public float num1, num2;

            public Numeros(float num1, float num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public float Calculo()
            {
                return num1 + num2;
            }

            public void Desplegar(float suma)
            {
                Console.WriteLine("La suma de los dos numeros es: "+ suma);
            }

            ~Numeros()
            {
                Console.WriteLine("Memoria liberada");
            }
        }

        static void Main(string[] args)
        {
            float num1, num2, suma1, suma2;

            Console.Write("Cual es tu primer numero? ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Cual es tu segundo numero? ");
            num2 = Int32.Parse(Console.ReadLine());

            Numeros nu = new Numeros(num1, num2);

            suma1 = nu.Calculo();
            nu.Desplegar(suma1);

            Console.Write("Pulsa enter para seguir con la proxima suma");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Cual es tu primer numero? ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Cual es tu segundo numero? ");
            num2 = Int32.Parse(Console.ReadLine());

            Numeros nu2 = new Numeros(num1, num2);

            suma2 = nu2.Calculo();
            nu2.Desplegar(suma2);

            Console.WriteLine("Pulsa enter para cerrar el programa");
            Console.ReadKey();
        }
    }
}
