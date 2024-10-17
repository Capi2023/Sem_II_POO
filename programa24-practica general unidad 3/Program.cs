using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa24_practica_general_unidad_3
{
    class Program
    {
        public class FuncionesMatematicas
        {
            //Atributos de la clase
            public float Angulo;

            //Contructor
            public FuncionesMatematicas(float Angulo)
            {
                this.Angulo = Angulo;
            }

            //Metodos
            public virtual double CalcularFuncion()
            {
                return 0;
            }

            public void DesplegarFuncion()
            {
            }

            //Destructor
            ~FuncionesMatematicas()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Funciones Matematicas ");
                Console.ReadLine();
            }
        }

        public class Seno : FuncionesMatematicas
        {
            //Constructor
            public Seno(float Angulo) : base(Angulo)
            {
            }

            //Metodos
            public override double CalcularFuncion()
            {
                base.CalcularFuncion();
                return Math.Sin(Angulo);
            }

            new public void DesplegarFuncion()
            {
                Console.WriteLine("El valor del angulo es de: "+ Angulo);
                Console.WriteLine("El resultado del seno es de: "+ CalcularFuncion());
            }

            //Desctructor
            ~Seno()
            {
                Console.WriteLine("Memoria Liberada Objeto Derivado Seno");
                Console.ReadLine();
            }
        }

        public class Coseno : FuncionesMatematicas
        {
            //Contructor
            public Coseno(float Angulo) : base(Angulo)
            {
            }

            //Metodos
            public override double CalcularFuncion()
            {
                base.CalcularFuncion();
                return Math.Cos(Angulo);
            }

            new public void DesplegarFuncion()
            {
                Console.WriteLine("El valor del angulo es de: " + Angulo);
                Console.WriteLine("El resultado del coseno es de: " + CalcularFuncion());
            }

            //Destructor
            ~Coseno()
            {
                Console.WriteLine("Memoria Liberada Objeto Derviado Coseno");
            }
        }

        public class Tangente : FuncionesMatematicas
        {
            //Contructor
            public Tangente(float Angulo) : base(Angulo)
            {
            }

            //Metodos
            public override double CalcularFuncion()
            {
                base.CalcularFuncion();
                return Math.Tan(Angulo);
            }

            new public void DesplegarFuncion()
            {
                Console.WriteLine("El valor del angulo es de: " + Angulo);
                Console.WriteLine("El resultado del la tagente es de: " + CalcularFuncion()); ;
            }

            //Desctructor
            ~Tangente()
            {
                Console.WriteLine("Memoria Liberada Objeto Derivado Tangente");
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            float angulo;
            double anguloT;

            //Asignacion de valores
            Console.Write("Cual es el angulo? ");
            angulo = Single.Parse(Console.ReadLine());

            //Creacion de objectos
            FuncionesMatematicas fun = new FuncionesMatematicas(angulo);
            Seno sin = new Seno(angulo);
            Coseno co = new Coseno(angulo);
            Tangente tan = new Tangente(angulo);


            //Metodos
            anguloT = sin.CalcularFuncion();
            sin.DesplegarFuncion();

            anguloT = co.CalcularFuncion();
            co.DesplegarFuncion();

            anguloT = tan.CalcularFuncion();
            tan.DesplegarFuncion();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
