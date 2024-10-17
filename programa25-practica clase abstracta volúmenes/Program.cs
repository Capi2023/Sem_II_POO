using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa25_practica_clase_abstracta_volúmenes
{
    class Program
    {
        public abstract class Figuras
        {
            //atributos
            public float radio, altura, lado;
            public double volumen;
            
            //métodos
            abstract public double calcularVolumen();
            abstract public void desplegarVolumen();
            
            //destructor
            ~Figuras()
            {
                Console.WriteLine("Memoria Objeto Clase Abstracta Figuras Liberada");
                Console.ReadKey();
            }
        }//fin clase base abstracta figuras

        public class Esfera : Figuras
        {
            // Constructor
            public Esfera(float radio)
            {
                this.radio = radio;
                this.lado = 0;
                this.altura = 0;
            }
            
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);
            }
            
            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio de la Esfera es: " +this.radio);
                Console.WriteLine("El volumen de la Esfera es: " +this.volumen);
            }
            
            //destructor
            ~Esfera()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Esfera Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada esfera

        public class Cubo : Figuras
        {
            // Constructor
            public Cubo(float lado)
            {
                this.radio = 0;
                this.lado = lado;
                this.altura = 0;
            }

            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = Math.Pow(lado, 3);
            }

            public override void desplegarVolumen()
            {
                Console.WriteLine("El lado del cubo es de: " + this.lado);
                Console.WriteLine("El volumen del cubo es de: " + this.volumen);
            }

            //destructor
            ~Cubo()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cubo Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada cubo

        public class Cilindro : Figuras
        {
            // Constructor
            public Cilindro(float radio, float altura)
            {
                this.radio = radio;
                this.lado = 0;
                this.altura = altura;
            }

            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = Math.PI * Math.Pow(radio, 2) * altura;
            }

            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio del cilindro es de: " + this.radio);
                Console.WriteLine("La altura del cilindro es de: " + this.altura);
                Console.WriteLine("El volumen del cilindro es de: " + this.volumen);
            }

            //destructor
            ~Cilindro()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cilindro Liberada");
                Console.ReadKey();
            }
        }//fin clase derivada cilindro

        public class Cono : Figuras
        {
            // Constructor
            public Cono(float radio, float altura)
            {
                this.radio = radio;
                this.lado = 0;
                this.altura = altura;
            }

            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = (1 / 3f) * Math.PI * Math.Pow(radio, 2) * altura;
            }

            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio del cono es de: " + this.radio);
                Console.WriteLine("La altura del cono es de: " + this.altura);
                Console.WriteLine("El volumen del cono es de: " + this.volumen);
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
