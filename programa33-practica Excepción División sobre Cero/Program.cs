using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa33_practica_Excepción_División_sobre_Cero
{
    class Program
    {
        static float Divide(float x, float y)
        {
            if (y == 0)
                throw new DivideByZeroException(); //lanzamiento de la excepción
            else return (x / y);
        }

        static void Main(string[] args)
        {
            //declaración de variables auxiliares
            float n1, n2, resultado;
            char opc = 'a';

            do
            {
                Console.WriteLine("MENU División sobre Cero");
                Console.WriteLine("a) Capturar y Realizar Operación");
                Console.WriteLine("b) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 'a':
                        try
                        { //captura de datos
                            Console.Clear();
                            Console.Write("\nAlimenta el valor del 1er número: ");
                            n1 = Single.Parse(Console.ReadLine());
                            Console.Write("\nAlimenta el valor del 2do número: ");
                            n2 = Single.Parse(Console.ReadLine());
                            
                            //llamada al método
                            resultado = Divide(n1, n2);
                            
                            //despliegue de resultado
                            Console.WriteLine("\nEl número "+ n1 +" dividido por "+ n2 +" da como resultado: " +resultado);
                            Console.Write("\npresione <enter> para continuar..."); Console.ReadKey();
                        }

                        catch (DivideByZeroException d)
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
                        }
                        break;
                    case 'b':
                        Console.Clear();
                        Console.WriteLine("Pulsa enter para salir del programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
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
