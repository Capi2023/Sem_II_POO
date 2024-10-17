using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa9_ejemplo_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia;
            string DiaL;
            Console.WriteLine("¿Que numero del dia de la semana desea saber?");
            Console.Write("(Ejemplo = 6)  ");
            Dia = Int32.Parse(Console.ReadLine());
            DiaL = "";

            //Selecion multiple de dia de la semana
            switch (Dia)
            {
                case 1:
                    DiaL = "Domingo";
                    break;
                case 2:
                    DiaL = "Lunes";
                    break;
                case 3:
                    DiaL = "Martes";
                    break;
                case 4:
                    DiaL = "Miercoles";
                    break;
                case 5:
                    DiaL = "Jueves";
                    break;
                case 6:
                    DiaL = "Viernes";
                    break;
                case 7:
                    DiaL = "Sabado";
                    break;
                default:
                    Console.WriteLine("El dia " + Dia + " no es un dia de la semana");
                    break;
            }
            if (Dia >= 1 && Dia <= 7)
            {
                Console.WriteLine("El dia de la semana es " + DiaL);
            }
            Console.WriteLine("Pulse enter para salir");
            Console.ReadKey();
        }
    }
}
