using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria___Triángulos
{
    public class Equilatero
    {
        //Vairables locales
        public float Lado;
        
        //Constructor
        public Equilatero(float Lado)
        {
            this.Lado = Lado;
        }

        //Métodos
        public double CalcularPerimetro()
        {
            return 3 * Lado;
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("El lado del triangulo mide: " + this.Lado);
            Console.WriteLine("El perimetro del triangulo equilatero es de: " + perimetro);
        }

        //Destructor
        ~Equilatero()
        {
            Console.WriteLine("Memoria Objeto Clase Equilatero Liberada");
        }
    }

    public class Isosceles
    {
        //Variables locales
        public float Base, Lado;
        
        //Constructor
        public Isosceles(float Base, float Lado)
        {
            this.Base = Base;
            this.Lado = Lado;
        }

        //Métodos
        public double CalcularPerimetro()
        {
            return 2 * Lado + Base;
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("La base del triangulo es de: " + this.Base);
            Console.WriteLine("El lado del triangulo mide: " + this.Lado);
            Console.WriteLine("El perimetro del triangulo isosceles es de: " + perimetro);
        }

        //Destructor
        ~Isosceles()
        {
            Console.WriteLine("Memoria Objeto Clase Isosceles Liberada");
        }
    }

    public class Escaleno
    {
        //Variables locales
        public float PLado, SLado, TLado;
        
        //Constructor
        public Escaleno(float PLado, float SLado, float TLado)
        {
            this.PLado = PLado;
            this.SLado = SLado;
            this.TLado = TLado;
        }

        //Métodos
        public double CalcularPerimetro()
        {
            return PLado + SLado + TLado;
        }

        public void DesplegarPerimetro(double perimetro)
        {
            Console.WriteLine("El primer lado del triangulo es de: " + this.PLado);
            Console.WriteLine("El segundo lado del triangulo es de: " + this.SLado);
            Console.WriteLine("El tercer lado del triangulo es de: " + this.TLado);
            Console.WriteLine("El perimetro del triangulo escaleno es de: " + perimetro);
        }

        //Destructor
        ~Escaleno()
        {
            Console.WriteLine("Memoria Objeto Clase Escaleno Liberada");
        }
    }

    public class Class1
    {
    }
}
