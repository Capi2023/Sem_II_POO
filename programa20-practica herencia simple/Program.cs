using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20_practica_herencia_simple
{
    class Program
    {
        public class Persona //clase base
        {
            public string nombre; // campo de objeto Persona que almacena su nombre
            public int edad; // campo de objeto Persona que almacena su edad
            public string nip; // campo de objeto Persona que almacena su NIP
                               // constructor de Persona
            public Persona(string nombre, int edad, string nip)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.nip = nip;
            }

            public void Cumpleaños() // método que incrementa en uno la Edad
            {
                edad++;
            }

            //Metodo de desplegar datos de la persona
            public void DesplegarDatosPersona()
            {
                Console.WriteLine("Nombre: "+ nombre);
                Console.WriteLine("Edad: "+ edad);
                Console.WriteLine("NIP: "+ nip);
            }

            //Destructor
            ~Persona()
            {
                Console.WriteLine("Liberado memoria persona"+ this.nombre);
                Console.ReadKey();
            }

        } //fin clase base

        public class Trabajador : Persona //clase derivada
        {
            public float sueldo; //campo de objeto Trabajador que almacena su sueldo
                                 //constructor de Trabajador
            public Trabajador(string nombre, int edad, string nip, float sueldo)
            : base(nombre, edad, nip) //inicializa Trabajador en base al constructor de la clase Persona
            {
                this.sueldo = sueldo;
            }

            //Metodo de desplegar datos del trabajdor
            public void DesplegarDatosTrabajador()
            {
                base.DesplegarDatosPersona();
                Console.WriteLine("Sueldo: {0:C}", sueldo);
            }

            //Destructor
            ~Trabajador()
            {
                Console.WriteLine("Liberado memoria trabajdor"+ this.nombre);
                Console.ReadKey();
            }

        } //fin clase derivada

        static void Main(string[] args)
        {
            //Creacion de objecto y capturacion de datos
            string nombre, nip;
            int edad, sueldo;

            //Capturacion de datos de la persona
            Console.WriteLine("Datos de la persona");
            Console.Write("Cual es su nombre? ");
            nombre = Console.ReadLine();
            Console.Write("Cual es su edad? ");
            edad = Int32.Parse(Console.ReadLine());
            Console.Write("Cual es su nip? ");
            nip = Console.ReadLine();

            //Creacion de objecto
            Persona t1 = new Persona(nombre, edad, nip);
            Console.WriteLine("Pulsa enter para desplegare datos de la persona");
            Console.ReadKey();
            t1.DesplegarDatosPersona();
            Console.ReadKey();

            //Capturacion de datos del trabajador
            Console.Clear();
            Console.WriteLine("Datos del trabajador");
            Console.WriteLine("Cual es su nombre? ");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es su edad? ");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cual es su nip? ");
            nip = Console.ReadLine();
            Console.WriteLine("Cual es su sueldo? ");
            sueldo = Int32.Parse(Console.ReadLine());

            //Creación del objeto de la clase Trabajador
            Trabajador t2 = new Trabajador(nombre, edad, nip, sueldo);
            Console.WriteLine("Pulsa enter para desplegare datos del trabajador");
            Console.ReadKey();
            t2.DesplegarDatosTrabajador();
            Console.ReadKey();
        }
    }
}
