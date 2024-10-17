using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria___Triángulos;

namespace GarciaCordero_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            float Plado, Slado, Tlado, Base;
            char opc;
            double perimetro;

            do
            {
                //Menu de opciones
                Console.WriteLine("¿Que opcion desea?");
                Console.WriteLine("a) Equilatero");
                Console.WriteLine("b) Isosceles");
                Console.WriteLine("c) Escaleno");
                Console.WriteLine("d) Salir del programa");
                opc = Char.Parse(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    //Caso equilatero
                    case 'a':
                        Console.Write("Cuanto mide el lado del triangulo equilatero? ");
                        Plado = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Equilatero eq = new Equilatero(Plado);

                        //Ejecucion de metodos
                        perimetro = eq.CalcularPerimetro();
                        eq.DesplegarPerimetro(perimetro);
                        break;
                    //Caso isosceles
                    case 'b':
                        Console.Write("Cuanto mide la base del triangulo isosceles? ");
                        Base = Single.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide el lado del triangulo isosceles? ");
                        Plado = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Isosceles iso = new Isosceles(Base, Plado);

                        //Ejecucion de metodos
                        perimetro = iso.CalcularPerimetro();
                        iso.DesplegarPerimetro(perimetro);
                        break;
                    //Caso escaleno
                    case 'c':
                        Console.Write("Cuanto mide el primer lado del triangulo escaleno? ");
                        Plado = Single.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide el segundo lado del triangulo escaleno? ");
                        Slado = Single.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide el tercer lado del triangulo escaleno? ");
                        Tlado = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Escaleno esc = new Escaleno(Plado, Slado, Tlado);

                        //Ejecucion de metodos
                        perimetro = esc.CalcularPerimetro();
                        esc.DesplegarPerimetro(perimetro);
                        break;
                    //Casi salir del programa
                    case 'd':
                        break;
                    //Caso default
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
