using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa31_practica_Excepcion_de_Formato
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables auxiliares
            int Base, Potencia;
            double Resultado;
            try
            { //captura de datos
                Console.Write("\nAlimenta el valor de la base: ");
                Base = Int32.Parse(Console.ReadLine());
                Console.Write("\nAlimenta el valor de la potencia: ");
                Potencia = Int32.Parse(Console.ReadLine());
                //llamada a la funcion matemática
                Resultado = Math.Pow(Base, Potencia);
                //despliegue del resultado
                Console.WriteLine("\nEl resultado es: {0}", Resultado);
                Console.Write("\npresione <enter> para continuar."); Console.ReadKey();
            }
            catch (FormatException f)
            {
                Console.WriteLine("\nMensaje del Error: " + f.Message);
                Console.WriteLine("\nRuta del Error: " + f.StackTrace);
                Console.Write("\npresione <enter> para continuar."); Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("\nPresione <enter> para Salir del Programa"); Console.ReadKey();
            }
        }
    }
}
