using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa28_practica_clase_abstracta_perímetros
{
    class Program
    {
        public abstract class Perimetros
        {
            public float lado, Base, altura, numerolados;
            public double perimetro;

            //métodos
            abstract public double CalcularPerimetro();
            abstract public void DesplegarPerimetro();

            //destructor
            ~Perimetros()
            {
                Console.WriteLine("Memoria Objeto Clase Abstracta Perimetros Liberada");
            }
        }//fin clase base abstracta

        public class Rombo : Perimetros
        {
            // Constructor
            public Rombo(float lado)
            {
                this.lado = lado;
                this.Base = 0;
                this.numerolados = 0;
                this.altura = 0;
            }

            // Implementación de Métodos Abstractos
            public override double CalcularPerimetro()
            {
                return this.perimetro = lado * 4;
            }

            public override void DesplegarPerimetro()
            {
                Console.WriteLine("El lado del cubo es de: " + this.lado);
                Console.WriteLine("El perimetro del cubo es de: " + this.perimetro);
            }

            //destructor
            ~Rombo()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Rombo Liberada");
            }
        }//fin clase derivada esfera

        public class Romboide : Perimetros
        {
            // Constructor
            public Romboide(float Base, float altura)
            {
                this.lado = 0;
                this.Base = Base;
                this.numerolados = 0;
                this.altura = altura;
            }

            // Implementación de Métodos Abstractos
            public override double CalcularPerimetro()
            {
                return this.perimetro = (2 * Base) + (2 * altura);
            }

            public override void DesplegarPerimetro()
            {
                Console.WriteLine("El lado del cubo es de: " + this.Base);
                Console.WriteLine("la altura del cubo es de: " + this.altura);
                Console.WriteLine("El perimetro del cubo es de: " + this.perimetro);
            }

            //destructor
            ~Romboide()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Romboide Liberada");
            }
        }//fin clase derivada esfera

        public class PoligonoRegular : Perimetros
        {
            // Constructor
            public PoligonoRegular(float lado, float numerolados)
            {
                this.lado = lado;
                this.Base = 0;
                this.numerolados = numerolados;
                this.altura = 0;
            }

            // Implementación de Métodos
            public override double CalcularPerimetro()
            {
                return this.perimetro = lado * numerolados;
            }

            public override void DesplegarPerimetro()
            {
                Console.WriteLine("El lado del poligono regular es de: " + this.lado);
                Console.WriteLine("El poligono tiene " + this.numerolados + " lados");
                Console.WriteLine("El perimetro del poligono regular: " + this.perimetro);
            }

            //destructor
            ~PoligonoRegular()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Poligono Regular Liberada");
            }
        }//fin clase derivada

        static void Main(string[] args)
        {
            //Declaracion de variables
            float lado, Base, altura, numlados;
            char opc;

            do
            {
                Console.WriteLine("¿Que opcion desea?");
                Console.WriteLine("a) Rombo");
                Console.WriteLine("b) Romboide");
                Console.WriteLine("c) Poligono regular");
                Console.WriteLine("d) Salir del programa");
                opc = Char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'a':
                        Console.Write("Cuanto mide el lado del rombo? ");
                        lado = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Rombo ro = new Rombo(lado);

                        //Ejecucion de metodos
                        ro.CalcularPerimetro();
                        ro.DesplegarPerimetro();
                        break;
                    case 'b':
                        Console.Write("Cuanto mide la base del romboide? ");
                        Base = Single.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide la altura del romboide? ");
                        altura = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Romboide romb = new Romboide(Base, altura);

                        //Ejecucion de metodos
                        romb.CalcularPerimetro();
                        romb.DesplegarPerimetro();
                        break;
                    case 'c':
                        //Asignacion de variables
                        Console.Write("Cuanto mide el lado del poligono regular? ");
                        lado = Single.Parse(Console.ReadLine());
                        Console.Write("Cuantos lados tiene el poligono regular? ");
                        numlados = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        PoligonoRegular poli = new PoligonoRegular(lado, numlados);

                        //Ejecucion de metodos
                        poli.CalcularPerimetro();
                        poli.DesplegarPerimetro();
                        break;
                    case 'd':
                        break;
                    default:
                        Console.WriteLine("La opcion " + opc + " no es una opcion valida");
                        break;
                }

                Console.WriteLine("Enter para continuar");
                Console.ReadKey();
                Console.Clear();

            } while (opc != 'd');
        }
    }
}
