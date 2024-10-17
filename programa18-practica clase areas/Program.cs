using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa18_practica_clase_areas
{
    class Program
    {
        public class Areas
        {
            //Aributos de la clase
            string nombreFigura;

            //Contructor de la clase
            public Areas (string nombreFigura)
            {
                this.nombreFigura = nombreFigura;
            }

            //Sobrecarga
            public double CalcularArea (float rad)
            {
                return Math.PI * Math.Pow(rad, 2);
            }

            //Proceso prara calcular el area del circulo
            public float CalcularArea(float lar, float anch)
            {
                return lar * anch;
            }

            //Proceso prara calcular el area del rectangulo
            public void DesplegarArea(double area)
            {
                Console.WriteLine("La figura "+ nombreFigura +" tiene el area de: {0:f4}", area);
            }

            //Destructor
            ~Areas()
            {
                Console.WriteLine("Objeto Destruido" + this.nombreFigura);
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de las varables
            float rad, largo, ancho;
            double areaC, areaR;

            //Captura de datos del circulo
            Console.Write("Cual es el radio del circulo: ");
            rad = Single.Parse(Console.ReadLine());

            //creación y asignación de valores a los objetos
            Areas ar1 = new Areas("Circulo");

            //Ejecucion de los métodos
            areaC = ar1.CalcularArea(rad);
            ar1.DesplegarArea(areaC);

            //Captura de datos del rectangulo
            Console.Write("Cual es el largo del rectangulo? ");
            largo = Single.Parse(Console.ReadLine());
            Console.Write("Cual es el ancho del rectangulo? ");
            ancho = Single.Parse(Console.ReadLine());

            //creación y asignación de valores a los objetos
            Areas ar2 = new Areas("Rectangulo");

            //Ejecucion de los métodos
            areaR = ar2.CalcularArea(largo, ancho);
            ar2.DesplegarArea(areaR);

            //Salida del programa
            Console.WriteLine("Pulse entar para cerrar el programa");
            Console.ReadKey();
        }
    }
}
