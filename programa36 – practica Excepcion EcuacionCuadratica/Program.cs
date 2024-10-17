using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36___practica_Excepcion_EcuacionCuadratica
{
    class Program
    {
        class NegativosException : ApplicationException//clase nueva excepción
        {
            //constructor de la clase
            public NegativosException() : base("La Ecuación Cuadrática NO tiene Solución!!!")
            { }
        }
        static void Main(string[] args)
        {

            //declaración de variables
            char opc = 'a';
            int a, b ,c;
            double Resultado, x1, x2;

            do
            {
                Console.WriteLine("MENU Ecuación Cuadrática");
                Console.WriteLine("a) Capturar Datos y Calcular Función");
                Console.WriteLine("b) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'a':
                        try
                        {
                            Console.Clear();
                            //captura de datos
                            Console.Write("Cual es el valor de a: ");
                            a = Int32.Parse(Console.ReadLine());
                            Console.Write("Cual es el valor de b: ");
                            b = Int32.Parse(Console.ReadLine());
                            Console.Write("Cual es el valor de c: ");
                            c = Int32.Parse(Console.ReadLine());

                            Resultado = (int)(Math.Pow(b, 2) - 4 * a * c);
                            if (Resultado < 0)
                            {
                                throw new NegativosException(); //lanzamiento de la excepción
                            }
                            else
                            {
                                //calcular función matemática
                                x1 = x1 = (int)(-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                                x2 = (int)(-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

                                //despliegue del resultado
                                Console.WriteLine("El valor de x1 es de: "+ x1);
                                Console.WriteLine("El valor de x2 es de: " + x2);
                                Console.WriteLine("\npresione <enter> para continuar...");
                                Console.ReadKey();
                            }
                        }
                        catch (NegativosException n)
                        {
                            Console.WriteLine("\nMensaje del error: " + n.Message);
                            Console.WriteLine("\nRuta del error: " + n.StackTrace);
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine("\nMensaje del error: " + f.Message);
                            Console.WriteLine("\nRuta del error: " + f.StackTrace);
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nPrograma desarrollado por: Garcia Cordero Emiliano - 20211779");
                            Console.WriteLine("\nMateria: Programación Orientada a Objetos 2A");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 'b':
                        Console.Clear();
                        Console.WriteLine("Pulsa enter para salir del programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("La opcion " + opc + " no es una opcion valida");
                        Console.WriteLine("Pulsa enter para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opc != 'b');

        }
    }
}
