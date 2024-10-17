using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Libreria___Perímetros;

namespace programa30_practica_librería_perímetros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            float lado, Base, altura, numlados;
            char opc;
            double perimetro;

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
                        perimetro = ro.CalcularPerimetro();
                        ro.DesplegarPerimetro(perimetro);
                        break;
                    case 'b':
                        Console.Write("Cuanto mide la base del romboide? ");
                        Base = Single.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide la altura del romboide? ");
                        altura = Single.Parse(Console.ReadLine());

                        //Objecto y parametros
                        Romboide romb = new Romboide(Base, altura);

                        //Ejecucion de metodos
                        perimetro = romb.CalcularPerimetro();
                        romb.DesplegarPerimetro(perimetro);
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
                        perimetro = poli.CalcularPerimetro();
                        poli.DesplegarPerimetro(perimetro);
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
