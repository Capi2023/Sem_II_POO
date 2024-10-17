using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa22_practica_constructores_y_destructores
{
    class Program
    {

        public class Escuela
        {
            //Atributos de la clase
            public string nombreEscuela, direccion;
            public float telefono;

            //Contructor
            public Escuela(string nombreEscuela, string direccion, float telefono)
            {
                this.nombreEscuela = nombreEscuela;
                this.direccion = direccion;
                this.telefono = telefono;
            }

            //Metodos
            public void desplegarEscuela()
            {
                Console.WriteLine("Nombre de la escuela: "+ nombreEscuela);
                Console.WriteLine("Direccion de la escuela: "+ direccion);
                Console.WriteLine("Numero de telefono de la escuela: "+ telefono);
            }

            //Destructor
            ~Escuela()
            {
                Console.WriteLine("Memoria liberada "+ this.nombreEscuela);
                Console.ReadKey();
            }
        }

        public class Alumno : Escuela
        {
            public string nombreAlumno, carrera;
            public int numeroControl;

            public Alumno(string nombreAlumno, int numeroControl, string carrera, string nombreEscuela, string direccion, float telefono)
            : base(nombreEscuela, direccion, telefono)
            {
                this.nombreAlumno = nombreAlumno;
                this.numeroControl = numeroControl;
                this.carrera = carrera;
            }

            public void desplegarAlumno()
            {
                base.desplegarEscuela();
                Console.WriteLine("Nombre del alumno: " + nombreAlumno);
                Console.WriteLine("Carrea: " + carrera);
                Console.WriteLine("Numero de control del alumno: " + numeroControl);
                Console.ReadKey();
            }

            //Destructor
            ~Alumno()
            {
                Console.WriteLine("Memoria liberada " + this.nombreAlumno);
                Console.ReadKey();
            }
        }


        public class Maestro : Escuela
        {
            //Atributos de la clase
            public string nombreMaestro, departamento;
            public int numeroFiliacion;

            //Contructor
            public Maestro(string nombreMaestro, int numeroFiliacion, string departamento, string nombreEscuela, string direccion, float telefono)
            : base(nombreEscuela, direccion, telefono)
            {
                this.nombreMaestro = nombreMaestro;
                this.numeroFiliacion = numeroFiliacion;
                this.departamento = departamento;
            }

            //Metodos
            public void desplegarMaestro()
            {
                base.desplegarEscuela();
                Console.WriteLine("Nombre del maestro: " + nombreMaestro);
                Console.WriteLine("Numero de filiacion: " + numeroFiliacion);
                Console.WriteLine("Departamento: " + departamento);
            }

            //Destructor
            ~Maestro()
            {
                Console.WriteLine("Memoria liberada " + this.nombreMaestro);
                Console.ReadKey();
            }
        }


        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombre, dire, nombreAlu, carrera, nombreMae, depa;
            int numCon, numFili;
            float telefono;

            //Asignacion de valores escuela
            Console.Write("Cual es el nombre de la escuela? ");
            nombre = Console.ReadLine();
            Console.Write("Cual es la direccion? ");
            dire = Console.ReadLine();
            Console.Write("Cual es el telefono de la escuela? ");
            telefono = Single.Parse(Console.ReadLine());

            //Creacion de objecto para escuela
            Escuela esc = new Escuela(nombre, dire, telefono);
            
            //Metodos
            esc.desplegarEscuela();
            Console.ReadKey();
            Console.Clear();

            //Asignacion de valores para alumno
            Console.Write("Cual es el nombre del alumno? ");
            nombreAlu = Console.ReadLine();
            Console.Write("Cual es la carrera? ");
            carrera = Console.ReadLine();
            Console.Write("Cual es su numero de control? ");
            numCon = Int32.Parse(Console.ReadLine());

            //Creacion de objecto par alumno
            Alumno alu = new Alumno(nombreAlu, numCon, carrera, nombre, dire, telefono);

            //Metodos
            alu.desplegarAlumno();
            Console.ReadKey();
            Console.Clear();

            //Asignacion de valores para maestro
            Console.Write("Cual es el nombre del maestro? ");
            nombreMae = Console.ReadLine();
            Console.Write("Cual es el departamento? ");
            depa = Console.ReadLine();
            Console.Write("Cual es el numero de filiacion? ");
            numFili = Int32.Parse(Console.ReadLine());

            //Creacion de objecto par alumno
            Maestro mae = new Maestro(nombreMae, numFili, depa, nombre, dire, telefono);

            //Metodos
            mae.desplegarMaestro();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
