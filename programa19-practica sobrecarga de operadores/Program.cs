using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa19_practica_sobrecarga_de_operadores
{
    class Program
    {
        public class NumerosComplejos
        {
            //Atributos de la clase
            public float real, imaginario;

            //Contructor
            public NumerosComplejos(float real, float imaginario)
            {
                this.real = real;
                this.imaginario = imaginario;
            }

            //Desplegar
            public override string ToString()
            {
                return (String.Format("{0} + {1}i", real, imaginario));
            }

            //Incremento
            public static NumerosComplejos operator ++(NumerosComplejos c1)
            {
                return new NumerosComplejos(c1.real + 1, c1.imaginario + 1);
            }

            //Decremento
            public static NumerosComplejos operator --(NumerosComplejos c1)
            {
                return new NumerosComplejos(c1.real - 1, c1.imaginario - 1);
            }

            //sobrecarga de operador binario + (suma)
            public static NumerosComplejos operator +(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.real + c2.real, c1.imaginario + c2.imaginario);
            }

            //sobrecarga de operador binario - (resta)
            public static NumerosComplejos operator -(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.real - c2.real, c1.imaginario - c2.imaginario);
            }

            //sobrecarga de operador binario * (multiplicacion)
            public static NumerosComplejos operator *(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.real * c2.real, c1.imaginario * c2.imaginario);
            }

            //sobrecarga de operador binario / (division)
            public static NumerosComplejos operator /(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.real / c2.real, c1.imaginario / c2.imaginario);
            }

            //Destructor
            ~NumerosComplejos()
            {
                Console.WriteLine("Memoria liberada NumerosComplejos");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de4 las variables
            int C1, C2;
            int I1, I2;

            //Capturacion de los datos
            Console.Write("Numero complejo 1: ");
            C1 = Int32.Parse(Console.ReadLine());
            Console.Write("Numero imagario 1: ");
            I1 = Int32.Parse(Console.ReadLine());
            
            Console.Write("Numero complejo 2: ");
            C2 = Int32.Parse(Console.ReadLine());
            Console.Write("Numero imaginario 2: ");
            I2 = Int32.Parse(Console.ReadLine());

            //creación y asignación de valores a los objetos
            NumerosComplejos c1 = new NumerosComplejos(C1, I1);
            NumerosComplejos c2 = new NumerosComplejos(C2, I2);
            
            //Sobrecarga de operadores
            c1++;
            c2--;

            //sobrecarga del operador suma
            NumerosComplejos suma = c1 + c2;
            NumerosComplejos resta = c1 - c2;
            NumerosComplejos multiplicacion = c1 * c2;
            NumerosComplejos division = c1 / c2;

            //mostramos los números y los resultados de las opereaciones usando el método ToString()
            Console.WriteLine("Primer número complejo: {0}", c1);
            Console.WriteLine("Segundo número complejo: {0}", c2);
            Console.WriteLine("La suma de los dos números es: {0}", suma);
            Console.WriteLine("La resta de los dos números es: {0}", resta);
            Console.WriteLine("La multiplicacion de los dos números es: {0}", multiplicacion);
            Console.WriteLine("La division de los dos números es: {0}", division);
            Console.WriteLine();
            
            //Salida del programa
            Console.WriteLine("Pulsa enter para salir del programa");
            Console.ReadLine();
        }
    }
}
