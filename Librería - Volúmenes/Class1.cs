using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería___Volúmenes
{
    public class Esfera
    {
        public float radio;
        // Constructor
        public Esfera(float radio)
        {
            this.radio = radio;
        }

        // Implementación de Métodos
        public double calcularVolumen()
        {
            return (4 / 3) * Math.PI * Math.Pow(radio, 3);
        }

        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El radio de la Esfera es: " + this.radio);
            Console.WriteLine("El volumen de la Esfera es: " + volumen);
        }

        //destructor
        ~Esfera()
        {
            Console.WriteLine("Memoria Objeto Clase Esfera Liberada");
            Console.ReadKey();
        }
    }//fin clase esfera

    public class Cubo
    {
        public float lado;

        // Constructor
        public Cubo(float lado)
        {
            this.lado = lado;
        }

        // Implementación de Métodos
        public double calcularVolumen()
        {
            return Math.Pow(lado, 3);
        }

        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El lado del cubo es de: " + this.lado);
            Console.WriteLine("El volumen del cubo es de: "+ volumen);
        }

        //destructor
        ~Cubo()
        {
            Console.WriteLine("Memoria Objeto Clase Cubo Liberada");
            Console.ReadKey();
        }
    }//fin clase cubo

    public class Cilindro
    {
        public float radio, altura;
        // Constructor
        public Cilindro(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        // Implementación de Métodos
        public double calcularVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El radio del cilindro es de: " + this.radio);
            Console.WriteLine("La altura del cilindro es de: " + this.altura);
            Console.WriteLine("El volumen del cilindro es de: "+ volumen);
        }

        //destructor
        ~Cilindro()
        {
            Console.WriteLine("Memoria Objeto Clase Cilindro Liberada");
            Console.ReadKey();
        }
    }//fin clase cilindro

    public class Cono
    {
        public float radio, altura;
        // Constructor
        public Cono(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        // Implementación de Métodos
        public double calcularVolumen()
        {
            return (1 / 3f) * Math.PI * Math.Pow(radio, 2) * altura;
        }

        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El radio del cono es de: " + this.radio);
            Console.WriteLine("La altura del cono es de: " + this.altura);
            Console.WriteLine("El volumen del cono es de: "+ volumen);
        }

        //destructor
        ~Cono()
        {
            Console.WriteLine("Memoria Objeto Clase Cono Liberada");
            Console.ReadKey();
        }
    }//fin clase cono
}
