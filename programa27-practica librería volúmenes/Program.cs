using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Librería___Volúmenes;

namespace programa27_practica_librería_volúmenes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            float radio, altura, lado;
            double volumen;

            //Asignacion de variables esfera
            Console.Write("Cual es el radio de la esfera? ");
            radio = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Esfera es = new Esfera(radio);

            //Ejecucion de metodos
            volumen = es.calcularVolumen();
            es.desplegarVolumen(volumen);
            Console.WriteLine("Pulsa enter para calcular el cubo");
            Console.ReadKey();
            Console.Clear();

            //Asignacion de variables para cubo
            Console.Write("Cuanto mide el lado del cubo? ");
            lado = Single.Parse(Console.ReadLine());

            //Objecto y parametros
            Cubo cu = new Cubo(lado);

            //Ejecucion de metodos
            volumen = cu.calcularVolumen();
            cu.desplegarVolumen(volumen);
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
            volumen = cil.calcularVolumen();
            cil.desplegarVolumen(volumen);
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
            volumen = con.calcularVolumen();
            con.desplegarVolumen(volumen);
            Console.WriteLine("Pulsa enter para salir del programa");
            Console.ReadKey();
        }
    }
}
