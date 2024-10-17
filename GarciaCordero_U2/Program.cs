using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCordero_U2
{
    class Program
    {
        public class EscolaresITT
        {
            //Atributos de la clase
            public float numeroControl;
            public string nombreAlumno, carrera;

            //Contructor
            public EscolaresITT(string nombreAlumno, float numeroControl, string carrera)
            {
                this.nombreAlumno = nombreAlumno;
                this.numeroControl = numeroControl;
                this.carrera = carrera;
            }

            //Metodos sobrecargados
            public float CalcularInscripcion(float cuotaI)
            {
                return cuotaI + (cuotaI * .08f);
            }

            public float CalcularInscripcion(float cuotaI, float cuotaS)
            {
                return (cuotaI + cuotaS) + ((cuotaI + cuotaS) * .08f);
            }

            public float CalcularInscripcion(float cuotaI, float cuotaS, float adeudos)
            {
                return (cuotaI + cuotaS + adeudos) + ((cuotaI + cuotaS + adeudos) * .08f);
            }

            //Despliegue de resultados
            public void DesplegarInscripcion(double I1, double I2, double I3)
            {
                Console.WriteLine("Numero de control: " + numeroControl);
                Console.WriteLine("Nombre del alumno: "+ nombreAlumno);
                Console.WriteLine("Carrera que cursa: "+ carrera);
                Console.WriteLine("El metodo de pago 1 le sale en: {0:c2}", I1);
                Console.WriteLine("El metodo de pago 2 le sale en: {0:c2}", I2);
                Console.WriteLine("El metodo de pago 3 le sale en: {0:c2}", I3);
                Console.ReadLine();
            }

            //Destructor
            ~EscolaresITT()
            {
                Console.WriteLine("Memoria Objecto Escolares Liberada " + this.nombreAlumno);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            string alu, carre;
            float n_control, cuotaI, cuotaS, adeudos, I1, I2, I3;

            //Capturacion de datos del alumno
            Console.Write("¿Cual es el nombre del alumno? ");
            alu = Console.ReadLine();
            Console.Write("¿Cual es su numero de control? ");
            n_control = Single.Parse(Console.ReadLine());
            Console.Write("¿Que carrera esta cursando? ");
            carre = Console.ReadLine();

            //Creacion de objecto con parametros
            EscolaresITT al = new EscolaresITT(alu, n_control, carre);

            Console.Clear();
            
            //Capturacion de datos de cuotas y adeudos
            Console.Write("¿Cual es la cuota de inscripcion? ");
            cuotaI = Int32.Parse(Console.ReadLine());
            Console.Write("¿Cual es la cuota de la sociedad de alumnos? ");
            cuotaS = Int32.Parse(Console.ReadLine());
            Console.Write("¿Cuanto es de los adeudos de la biblioteca? ");
            adeudos = Int32.Parse(Console.ReadLine());

            //Ejecucion de metodos
            Console.Clear();
            I1 = al.CalcularInscripcion(cuotaI);
            I2 = al.CalcularInscripcion(cuotaI, cuotaS);
            I3 = al.CalcularInscripcion(cuotaI, cuotaS, adeudos);
            al.DesplegarInscripcion(I1, I2, I3);
        }
    }
}
