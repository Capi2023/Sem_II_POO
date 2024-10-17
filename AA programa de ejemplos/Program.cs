using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_programa_de_ejemplos
{
    class Program
    {
        public class Telefono
        {
            public string lleno, prendido;

            public Telefono(string lleno, string prendido)
            {
                this.lleno = lleno;
                this.prendido = prendido;
            }

            public virtual void Info()
            {
                Console.WriteLine("El celular durara minimo 8 horas prendido?: " + lleno);
                Console.WriteLine("El celular esta en uso?: " + prendido);
            }

            ~Telefono()
            {
                Console.WriteLine("Memoria liberada Celular");
                Console.ReadKey();
            }
        }

        public class Laptop : Telefono
        {
            public float llen;

            public Laptop(string llen, string lleno, string prendido)
            : base(llen, prendido)
            {
                this.lleno = lleno;
            }

            public override void Info()
            {
                Console.WriteLine("La laptop se puede llevar de viaje?: " + lleno);
            }

            ~Laptop()
            {
                Console.WriteLine("Memoria liberada cuadrado");
                Console.ReadKey();
            }

        }

        static void Main(string[] args)
        {
            string bateria, encendido;

            Console.Write("La bateria del celular esta lleno? ");
            bateria = Console.ReadLine();
            Console.Write("El celular esta prendido? ");
            encendido = Console.ReadLine();

            Telefono cel = new Telefono(bateria, encendido);

            cel.Info();
            Console.ReadKey();

            Console.Write("La laptop tiene la bateria llena? ");
            bateria = Console.ReadLine();
            Laptop la = new Laptop(bateria, bateria, encendido);

            la.Info();

            Console.ReadKey();
        }
    }
}
