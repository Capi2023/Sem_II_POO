using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa8_ejemplo_función
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Datos();
        }

        private void Datos()
        {
            //Declaracion de variables
            float Dist, Tiempo;
            float Velo;

            Console.Write("¿Cual es la distancia recorida? ");
            Dist = Single.Parse(Console.ReadLine());

            Console.Write("¿Cual es su tiempo? ");
            Tiempo = Single.Parse(Console.ReadLine());

            //Llamda de funcion C()
            Velo = C(Dist, Tiempo);

            //Salida de resultado
            Console.WriteLine("Su velocidad es de= "+ Velo);
            Console.WriteLine("Pulse enter para salir del programa");
            Console.ReadKey();
        }

        //Creado para la conversion
        float C(float K, float T)
        {
            //Declaracion de variables
            float M;

            //Conversion de kilometros a millas y retorno
            M = K / 1.609f;
            return M / T;
        }
    }
}
