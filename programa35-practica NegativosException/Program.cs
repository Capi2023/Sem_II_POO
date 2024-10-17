using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa35_practica_NegativosException
{
    class Program
    {
        class NegativosException : ApplicationException //clase nueva excepción
        {
            //constructor de la clase
            public NegativosException() : base("NO se puede calcular el seno de un Angulo Negativo!!!")
            { }
        }

        static void Main(string[] args)
        {
            //declaración de variables
            char opc = 'a';
            int Angulo;
            double Resultado;

            do
            {
                Console.WriteLine("MENU Seno de un Angulo.");
                Console.WriteLine("a) Capturar y Realizar Seno");
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
                            Console.Write("Alimenta un numero entero: ");
                            Angulo = Int32.Parse(Console.ReadLine());
                            if (Angulo < 0)
                            {
                                throw new NegativosException(); //lanzamiento de la excepción
                            }
                            else
                            {
                                //calcular función matemática
                                Resultado = Math.Sin(Angulo);
                                //despliegue del resultado
                                Console.WriteLine("El Seno del Angulo {0} es : {1}", Angulo,
                                Resultado);
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
                            Console.WriteLine("\nEl finally siempre se ejecuta.");
                            Console.WriteLine("\npresione <enter> para continuar...");
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
