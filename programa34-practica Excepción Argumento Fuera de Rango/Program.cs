using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa34_practica_Excepción_Argumento_Fuera_de_Rango
{
    class Program
    {
        static double ABC(double Base)
        {
            if (Base > 999)
                throw new ArgumentOutOfRangeException(); //lanzamiento de la excepción
            else return Math.Pow(Base, 5);
        }

        static void Main(string[] args)
        {
            //declaración de variables auxiliares
            int Base;
            double res;
            char opc = 'a';

            do
            {
                Console.WriteLine("MENU Numero a la 5ta Potencia");
                Console.WriteLine("a) Capturar y Realizar Función");
                Console.WriteLine("b) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 'a':
                        Console.Clear();
                        try
                        { //captura de datos
                            Console.Write("Alimenta un numero entero: ");
                            Base = Int32.Parse(Console.ReadLine());

                            res = ABC(Base);
                            //despliegue de resultado
                            Console.WriteLine("\nEl número " + Base + " elevado a la 5ta potencia da como resultado: " + res);
                            Console.Write("\nPresione <enter> para continuar..."); Console.ReadKey();
                        }

                        catch (ArgumentOutOfRangeException d)
                        {
                            Console.WriteLine("\nMensaje del Error: " + d.Message);
                            Console.WriteLine("\nRuta del Error: " + d.StackTrace);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine("\nMensaje del Error: " + f.Message);
                            Console.WriteLine("\nRuta del Error: " + f.StackTrace);
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                            Console.WriteLine("\nPresione <ENTER> para Salir del Programa.");
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
