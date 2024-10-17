using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa23_practica_redefinición_de_métodos
{
    class Program
    {
        public class Areas
        {
            //Atributos de la clase
            public double radio;

            //Contructor
            public Areas(double radio)
            {
                this.radio = radio;
            }

            //Metodos
            public virtual double CalcularArea()
            {
                return 0;
            }

            public virtual void ImprimeArea()
            {

            }

            //Destructor
            ~Areas()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Areas ");
                Console.ReadKey();
            }
        }

        public class Circulo : Areas
        {
            public Circulo(double radio) : base(radio)
            {
            }

            public override double CalcularArea()
            {
                base.CalcularArea();
                return Math.PI * Math.Pow(radio, 2);
            }

            public override void ImprimeArea()
            {
                Console.WriteLine("El area del circulo es de: "+ CalcularArea());
            }
            ~Circulo()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Areas ");
                Console.ReadKey();
            }

        }

        public class Esfera : Areas
        {
            public Esfera(float radio) : base(radio)
            {
            }
            public override double CalcularArea()
            {
                base.CalcularArea();
                return 4 * Math.PI * Math.Pow(radio, 2);
            }

            public override void ImprimeArea()
            {
                Console.WriteLine("El area de la esfera es de: " + CalcularArea());
            }
            ~Esfera()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Areas ");
                Console.ReadKey();
            }

        }

        public class Cilindro : Areas
        {
            public float altura;

            public Cilindro(float altura, float radio) : base(radio)
            {
                this.altura = altura;
            }

            public override double CalcularArea()
            {
                base.CalcularArea();
                return 2 * Math.PI * radio * (altura + radio);
            }

            public override void ImprimeArea()
            {
                Console.WriteLine("El area del cilindro es de: " + CalcularArea());
            }

            ~Cilindro()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Areas ");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            float rad, altura;
            double radT;

            //Asignacion del radio
            Console.Write("Cual es el radio? ");
            rad = Single.Parse(Console.ReadLine());

            //Creacion de objecto para radio
            Areas area = new Areas(rad);

            //Creacion de objecto y metodos de circulo
            Circulo cir = new Circulo(rad);
            radT = cir.CalcularArea();
            cir.ImprimeArea();

            //Creacion de objecto y metodos de esfera
            Esfera es = new Esfera(rad);
            radT = es.CalcularArea();
            es.ImprimeArea();

            //Capturacion de datos del cilindro
            Console.Write("Cual es la altura del cilindro? ");
            altura = Single.Parse(Console.ReadLine());

            //Creaciond e objecto y metodos de cilindro
            Cilindro ci = new Cilindro(rad, altura);
            radT = ci.CalcularArea();
            ci.ImprimeArea();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
