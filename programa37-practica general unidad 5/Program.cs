using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37_practica_general_unidad_5
{
    class Program
    {
        class ParametroFueraDeRango : ApplicationException//clase nueva excepcion
        {
            //contructor de la clase
            public ParametroFueraDeRango() : base("El Número Alimentado está fuera del Rango establecido")
            { }
        }

        class ParametroInvalido : ApplicationException//clase nueva excepcion
        {
            //contructor de la clase
            public ParametroInvalido() : base("El numero Inválido para esta Operación")
            { }
        }

        class ParametroNulo : ApplicationException//clase nueva excepcion
        {
            //contructor de la clase
            public ParametroNulo() : base("El Valor del Numero debe ser Diferente de Cero")
            { }
        }

        static void Main(string[] args)
        {
            //declaración de variables
            byte opc = 1;
            float Base;
            double cos, tan;

            do
            {
                Console.WriteLine("Menú FUNCIONES");
                Console.WriteLine("1) Calcular Coseno y Tangente");
                Console.WriteLine("2) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = Byte.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        try
                        {
                            Console.Clear();
                            //captura de datos
                            Console.Write("Cual es el valor Base: ");
                            Base = Single.Parse(Console.ReadLine());

                            if (Base > 5000)
                            {
                                throw new ParametroFueraDeRango(); //lanzamiento de la excepción
                            }
                            else if (Base < 0)
                            {
                                throw new ParametroInvalido(); //lanzamiento de la excepción
                            }
                            else if (Base == 0)
                            {
                                throw new ParametroNulo(); //lanzamiento de la excepción
                            }
                            else
                            {
                                cos = Math.Cos(Base);
                                tan = Math.Tan(Base);
                                Console.WriteLine("El valor de la Base es de: "+Base);
                                Console.WriteLine("El coseno de "+ Base +" es de: "+cos);
                                Console.WriteLine("El tangente de " + Base + " es de: " + tan);
                                Console.WriteLine("\nPulsa enter para continuar");
                                Console.ReadKey();
                            }
                        }
                        catch (ParametroFueraDeRango n)
                        {
                            Console.WriteLine("\nMensaje del error: " + n.Message);
                            Console.WriteLine("\nRuta del error: " + n.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (ParametroInvalido r)
                        {
                            Console.WriteLine("\nMensaje del error: " + r.Message);
                            Console.WriteLine("\nRuta del error: " + r.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (ParametroNulo e)
                        {
                            Console.WriteLine("\nMensaje del error: " + e.Message);
                            Console.WriteLine("\nRuta del error: " + e.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }

                        catch (FormatException f)
                        {
                            Console.WriteLine("\nMensaje del error: " + f.Message);
                            Console.WriteLine("\nRuta del error: " + f.StackTrace);
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nEl finally siempre se ejecuta.");
                            Console.WriteLine("\nPresione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
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
            } while (opc != 2);
        }
    }
}
