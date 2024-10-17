using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria___Perímetros
{

    public class Rombo
    {
        public float Lado;
        // Constructor
        public Rombo(float Lado)
        {
            this.Lado = Lado;
        }

        // Implementación de Métodos
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("El lado del cubo es de: " + this.Lado);
            Console.WriteLine("El perimetro del cubo es de: " + perimetro);
        }

        //destructor
        ~Rombo()
        {
            Console.WriteLine("Memoria Objeto Clase Rombo Liberada");
        }
    }//fin clase

    public class Romboide
    {
        public float Base, Altura;
        // Constructor
        public Romboide(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        // Implementación de Métodos
        public double CalcularPerimetro()
        {
            return (2 * Base) + (2 * Altura);
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("La base del romboide es de: " + this.Base);
            Console.WriteLine("La altura del romboide es de: " + this.Altura);
            Console.WriteLine("El volumen de la Esfera es: " + perimetro);
        }

        //destructor
        ~Romboide()
        {
            Console.WriteLine("Memoria Objeto Clase Romboide Liberada");
        }
    }

    public class PoligonoRegular
    {
        public float Lado, NumeroLados;
        // Constructor
        public PoligonoRegular(float Lado, float NumeroLados)
        {
            this.Lado = Lado;
            this.NumeroLados = NumeroLados;
        }

        // Implementación de Métodos
        public double CalcularPerimetro()
        {
            return Lado * NumeroLados;
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("El lado del poligono regular es de: " + this.Lado);
            Console.WriteLine("El poligono tiene " + this.NumeroLados + " lados");
            Console.WriteLine("El perimetro del poligono regular: " + perimetro);
        }

        //destructor
        ~PoligonoRegular()
        {
            Console.WriteLine("Memoria Objeto Clase PoligonoRegular Liberada");
        }
    }

    public class Class1
        {
        }
}
