using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa26_practica_interfaz_volúmenes
{
    class Program
    {
        public static double volumen;

        interface IFiguras
        {
            //Métodos
            double calcularVolumen();
            void desplegarVolumen();
        }

        public class Esfera : IFiguras
        {
            public float radio;
            // Constructor
            public Esfera(float radio)
            {
                this.radio = radio;
            }

            // Implementación de Métodos Abstractos
            public double calcularVolumen()
            {
                return volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);
            }

            public void desplegarVolumen()
            {
                Console.WriteLine("El radio de la Esfera es: " + radio);
                Console.WriteLine("El volumen de la Esfera es: {0:f4}", volumen);
            }

            //destructor
            ~Esfera()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Esfera Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada esfera

        public class Cubo : IFiguras
        {
            public float lado;
            // Constructor
            public Cubo(float lado)
            {
                this.lado = lado;
            }
            // Implementación de Métodos Abstractos
            public double calcularVolumen()
            {
                return volumen = Math.Pow(lado, 3);
            }

            public void desplegarVolumen()
            {
                Console.WriteLine("El lado del cubo es de: " + lado);
                Console.WriteLine("El volumen del cubo es de: {0:f4}", volumen);
            }

            //destructor
            ~Cubo()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cubo Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada cubo

        public class Cilindro : IFiguras
        {
            public float radio, altura;
            
            // Constructor
            public Cilindro(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            // Implementación de Métodos Abstractos
            public double calcularVolumen()
            {
                return volumen = Math.PI * Math.Pow(radio, 2) * altura;
            }

            public void desplegarVolumen()
            {
                Console.WriteLine("El radio del cilindro es de: " + radio);
                Console.WriteLine("La altura del cilindro es de: " + altura);
                Console.WriteLine("El volumen del cilindro es de: {0:f4}", volumen);
            }

            //destructor
            ~Cilindro()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cilindro Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada cilindro

        public class Cono : IFiguras
        {
            public float radio, altura;
            // Constructor
            public Cono(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            // Implementación de Métodos Abstractos
            public double calcularVolumen()
            {
                return volumen = (1 / 3f) * Math.PI * Math.Pow(radio, 2) * altura;
            }

            public void desplegarVolumen()
            {
                Console.WriteLine("El radio del cono es de: " + radio);
                Console.WriteLine("La altura del cono es de: " + altura);
                Console.WriteLine("El volumen del cono es de: {0:f4}", volumen);
            }

            //destructor
            ~Cono()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cono Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada cono
        static void Main(string[] args)
        {
            //Declaracion de variables
            float radio, altura, lado;

            //Asignacion de variables esfera
            Console.Write("Cual es el radio de la esfera? ");
            radio = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Esfera es = new Esfera(radio);

            //Ejecucion de metodos
            es.calcularVolumen();
            es.desplegarVolumen();
            Console.WriteLine("Pulsa enter para calcular el cubo");
            Console.ReadKey();
            Console.Clear();

            //Asignacion de variables para cubo
            Console.Write("Cuanto mide el lado del cubo? ");
            lado = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Cubo cu = new Cubo(lado);

            //Ejecucion de metodos
            cu.calcularVolumen();
            cu.desplegarVolumen();
            Console.WriteLine("Pulsa enter para calcular el cilindro");
            Console.ReadKey();
            Console.Clear();

            //Asignacion de variables para cilindro
            Console.Write("Cual es el radio del cilindro? ");
            radio = Single.Parse(Console.ReadLine());
            Console.Write("Cual es la altrua del cilindro? ");
            altura = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Cilindro cil = new Cilindro(radio, altura);

            //Ejecucion de metodos
            cil.calcularVolumen();
            cil.desplegarVolumen();
            Console.WriteLine("Pulsa enter para calcular el cono");
            Console.ReadKey();
            Console.Clear();

            //Asignacion de variables para cono
            Console.Write("Cual es el radio del cono? ");
            radio = Single.Parse(Console.ReadLine());
            Console.Write("Cual es la altura del cono? ");
            altura = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Cono con = new Cono(radio, altura);

            //Ejecucion de metodos
            con.calcularVolumen();
            con.desplegarVolumen();
            Console.WriteLine("Pulsa enter para salir del programa");
            Console.ReadKey();
        }
    }
}
