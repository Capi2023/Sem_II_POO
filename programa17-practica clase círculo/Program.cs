using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa17_practica_clase_círculo
{
    class Program
    {
        public class Circulo
        {
            //Campos de la clase
            float radio;

            //Contructores
            public Circulo()
            {
                Console.WriteLine("Capturado sin datos");
            }

            public Circulo(float radio)
            {
                this.radio = radio;
            }

            //Metodos de la clase
            public double CalcularArea()
            {
                return Math.PI * Math.Pow(radio, 2);
            }

            public double CalcularCircunferencia()
            {
                return 2 * Math.PI * radio;
            }

            //Despliegue de los resultados
            public void DesplegarResultados(double area, double circu)
            {
                Console.WriteLine("Area del circulo: {0:f4}", area);
                Console.WriteLine("Circunferencia del círculo: {0:f4}", circu);
            }

            //Destructor
            ~Circulo()
            {
                Console.WriteLine("Memoria Liberada Objeto Círculo");
                Console.ReadLine();
            }

        }


        static void Main(string[] args)
        {
            //Declaracion de las variables
            float rad;
            double area, cir;
            
            //Capturacion de datos
            Console.Write("Cual es el radio del circulo? ");
            rad = Single.Parse(Console.ReadLine());

            //Creacion de objectos con y sin parametros
            Circulo ci1 = new Circulo();
            Circulo ci2 = new Circulo(rad);
            
            //Ejecucion de metodos
            area = ci2.CalcularArea();
            cir = ci2.CalcularCircunferencia();
            ci2.DesplegarResultados(area, cir);

            //Salida del programa
            Console.WriteLine("Presione enter para salir del programa");
            Console.ReadKey();
        }
    }
}
