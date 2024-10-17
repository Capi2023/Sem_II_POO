using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21_practica_modificador_new
{
    class Program
    {
        public class Rectangulo
        {
            //Atributos de la clase
            public float largo, ancho;

            //Contructor
            public Rectangulo(float largo, float ancho)
            {
                this.largo = largo;
                this.ancho = ancho;
            }

            //Metodo
            public void Area()
            {
                Console.WriteLine("El area del rectangulo es de: "+ (largo * ancho));
            }

            public void Perimetro()
            {
                Console.WriteLine("El perimetro del rectangulo es de: " + (2 * (largo + ancho)));
            }

            //Destructor
            ~Rectangulo()
            {
                Console.WriteLine("Memoria liberada Rectangulo");
                Console.ReadKey();
            }
        }

        public class Cuadrado : Rectangulo
        {
            public float lar;

            public Cuadrado(float lar, float largo, float ancho)
            : base (largo, ancho)
            {
                this.lar = lar;
            }

            new public void Area()
            {
                Console.WriteLine("El area del cuadrado es de: " + (lar * lar));
            }

            new public void Perimetro()
            {
                Console.WriteLine("El perimetro del cuadrado es de: " + (4 * lar));
            }

            ~Cuadrado()
            {
                Console.WriteLine("Memoria liberada cuadrado");
                Console.ReadKey();
            }

        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            float largo, ancho;

            //Capturacion de datos
            Console.Write("Cual es el largo del rectagulo");
            largo = Single.Parse(Console.ReadLine());
            Console.Write("Cual es el ancho del rectnagulo");
            ancho = Single.Parse(Console.ReadLine());

            //Creacion de obejcto
            Rectangulo rec = new Rectangulo(largo, ancho);
            //Metodo
            rec.Area();
            rec.Perimetro();
            Console.ReadKey();

            Console.Write("Cual es el largo del cuadrado");
            largo = Single.Parse(Console.ReadLine());
            Cuadrado cua = new Cuadrado(largo, largo, ancho);

            cua.Area();
            cua.Perimetro();

            Console.ReadKey();
        }
    }
}
