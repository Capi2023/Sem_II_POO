using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2_ejemplo_condición_compuesta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que le da un bono extra si participo en el proytecto general y es del departamento de Sistemas
            int Sue;
            float Neto;
            string Nom, Depa, Part;

            Console.Write("Nombre de empleado: ");
            Nom = Console.ReadLine();
            Console.Write("Departamento: ");
            Depa = Console.ReadLine();
            Console.WriteLine("¿Participo en proyecto general?");
            Console.WriteLine("Teclear P si participo");
            Console.Write("Teclear No si no participo");
            Part = Console.ReadLine();
            Console.Write("Sueldo de empleado: ");
            Sue = Int32.Parse(Console.ReadLine());

            if (Depa == "Sistemas" && Part == "P")
            {
                Neto = Sue + (Sue * .3f);
                Console.WriteLine("Sueldo neto: " + Neto);
            }
            else
            {
                Console.WriteLine("No aplica para el bono");
                Console.WriteLine("Sueldo neto: " + Sue);
            }
            Console.WriteLine("Pulsar enter para salir del programa");
            Console.ReadKey();
        }
    }
}
