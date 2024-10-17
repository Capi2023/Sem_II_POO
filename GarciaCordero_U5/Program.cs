using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCordero_U5
{
    class Program
    {
        class ExcepcionPotenciaSinSolucion : ApplicationException//clase nueva excepcion
        {
            //contructor de la clase
            public ExcepcionPotenciaSinSolucion() : base("Potencia Sin Solución Para Números Negativos")
            { }
        }

        static void Main(string[] args)
        {
            //declaración de variables
            char opc = 'a';
            int Base, Exponente;
            double res;

            do
            {
                Console.WriteLine("MENU POTENCIA");
                Console.WriteLine("a) Calcular y Desplegar Resultado");
                Console.WriteLine("b) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = Char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'a':
                        try
                        {
                            Console.Clear();
                            //captura de datos
                            Console.Write("Cual es el valor Base: ");
                            Base = Int32.Parse(Console.ReadLine());

                            if (Base == 0)
                            {
                                throw new ArgumentNullException(); //lanzamiento de la excepción
                            }
                            else if (Base > 1000)
                            {
                                throw new ArgumentOutOfRangeException(); //lanzamiento de la excepción
                            }
                            else
                            {
                                Console.Write("Cual es el exponente: ");
                                Exponente = Int32.Parse(Console.ReadLine());

                                if (Exponente < 0)
                                {
                                    throw new ExcepcionPotenciaSinSolucion(); //lanzamiento de la excepcion
                                }
                                else if (Exponente > 15)
                                {
                                    throw new OverflowException(); //lanzamiento de la excepcion
                                }
                                else
                                {
                                    res = Math.Pow(Base,Exponente);
                                    Console.WriteLine("El valor de la Base es de: " + Base);
                                    Console.WriteLine("El exponente de la Base es de: " + Exponente);
                                    Console.WriteLine("El resultado es: "+ res);
                                    Console.WriteLine("\nPulsa enter para continuar");
                                    Console.ReadKey();
                                }
                            }
                        }
                        catch (ExcepcionPotenciaSinSolucion a)
                        {
                            Console.WriteLine("\nMensaje del error: " + a.Message);
                            Console.WriteLine("\nRuta del error: " + a.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (ArgumentNullException b)
                        {
                            Console.WriteLine("\nMensaje del error: " + b.Message);
                            Console.WriteLine("\nRuta del error: " + b.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (ArgumentOutOfRangeException c)
                        {
                            Console.WriteLine("\nMensaje del error: " + c.Message);
                            Console.WriteLine("\nRuta del error: " + c.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (OverflowException d)
                        {
                            Console.WriteLine("\nMensaje del error: " + d.Message);
                            Console.WriteLine("\nRuta del error: " + d.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (FormatException e)
                        {
                            Console.WriteLine("\nMensaje del error: " + e.Message);
                            Console.WriteLine("\nRuta del error: " + e.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nPrograma desarrollado por: Emiliano Garcia Cordero - 20211779");
                            Console.WriteLine("Examen Programación Orientada a Objetos U5");
                            Console.WriteLine("\nPresione enter para continuar");
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
