using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        public class Vectores
        {
            //Atributos de la clase
            public float Px, Py, Pz, Dx, Dy, Dz, Vx, Vy, Vz;

            //Contructor
            public Vectores(float Px, float Py, float Pz, float Dx, float Dy, float Dz)
            {
                this.Px = Px;
                this.Py = Py;
                this.Pz = Pz;
                this.Dx = Dx;
                this.Dy = Dy;
                this.Dz = Dz;
            }

            //Metodos
            public virtual float Calcularx()
            {
                return 0;
            }

            public virtual float Calculary()
            {
                return 0;
            }

            public virtual float Calcularz()
            {
                return 0;
            }

            public void Desplegar()
            {
            }
        }

        public class Suma : Vectores
        {
            //Constructor
            public Suma(float Px, float Py, float Pz, float Dx, float Dy, float Dz)
            : base(Px, Py, Pz, Dx, Dy, Dz)
            {
            }

            //Metodos
            public override float Calcularx()
            {
                base.Calcularx();
                return (Px + Dx);
            }

            public override float Calculary()
            {
                base.Calculary();
                return (Py + Dy);
            }

            public override float Calcularz()
            {
                base.Calcularz();
                return (Pz + Dz);
            }

            public void Desplegar(float Vx, float Vy, float Vz)
            {
                Console.WriteLine("El resultado de la suma es de: "+ Vx +"i;"+Vy +"j; " +Vz+"k");
            }
        }

        public class Resta : Vectores
        {
            //Contructor
            public Resta(float Px, float Py, float Pz, float Dx, float Dy, float Dz) : base(Px, Py, Pz, Dx, Dy, Dz)
            {
            }

            //Metodos
            public override float Calcularx()
            {
                base.Calcularx();
                return (Px - Dx);
            }

            public override float Calculary()
            {
                base.Calculary();
                return (Py - Dy);
            }

            public override float Calcularz()
            {
                base.Calcularz();
                return (Pz - Dz);
            }

            public void Desplegar(float Vx, float Vy, float Vz)
            {
                Console.WriteLine("El resultado de la resta es de: " + Vx + "i;" + Vy + "j; " + Vz + "k");
            }
        }

        public class Punto : Vectores
        {
            //Contructor
            public Punto(float Px, float Py, float Pz, float Dx, float Dy, float Dz) : base(Px, Py, Pz, Dx, Dy, Dz)
            {
            }

            //Metodos
            public override float Calcularx()
            {
                base.Calcularx();
                return (Px * Dx);
            }

            public override float Calculary()
            {
                base.Calculary();
                return (Py * Dy);
            }

            public override float Calcularz()
            {
                base.Calcularz();
                return (Pz * Dz);
            }

            public void Desplegar(float Vx, float Vy, float Vz)
            {
                Console.WriteLine("El resultado del producto punto es de: " + Vx + "i;" + Vy + "j; " + Vz + "k");
            }
        }

        public class Cruz : Vectores
        {
            //Contructor
            public Cruz(float Px, float Py, float Pz, float Dx, float Dy, float Dz) : base(Px, Py, Pz, Dx, Dy, Dz)
            {
            }

            //Metodos
            public override float Calcularx()
            {
                base.Calcularx();
                return ((Py * Dz)-(Dy * Pz));
            }

            public override float Calculary()
            {
                base.Calculary();
                return ((Px - Dz) - (Dx - Pz));
            }

            public override float Calcularz()
            {
                base.Calcularz();
                return ((Px * Dy) - (Dx * Py));
            }

            public void Desplegar(float Vx, float Vy, float Vz)
            {
                Console.WriteLine("El resultado del producto cruz es de: " + Vx + "i;" + Vy + "j; " + Vz + "k");
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            char opcA, opcB;
            float Px, Py, Pz, Dx, Dy, Dz, Vx, Vy, Vz;

            do
            {
                //Asignacion de variables
                Console.Write("Cual es el valor de x en el primer vector? ");
                Px = Single.Parse(Console.ReadLine());

                Console.Write("Cual es el valor de y en el primer vector? ");
                Py = Single.Parse(Console.ReadLine());

                Console.Write("Cual es el valor de z en el primer vector? ");
                Pz = Single.Parse(Console.ReadLine());

                do
                {
                    Console.Write("Cual es el valor de x en el segundo vector? ");
                    Dx = Single.Parse(Console.ReadLine());

                    Console.Write("Cual es el valor de y en el segundo vector? ");
                    Dy = Single.Parse(Console.ReadLine());

                    Console.Write("Cual es el valor de z en el segundo vector? ");
                    Dz = Single.Parse(Console.ReadLine());

                    //Creacion de objectos
                    Vectores vec = new Vectores(Px, Py, Pz, Dx, Dy, Dz);
                    Suma s = new Suma(Px, Py, Pz, Dx, Dy, Dz);
                    Resta r = new Resta(Px, Py, Pz, Dx, Dy, Dz);
                    Punto p = new Punto(Px, Py, Pz, Dx, Dy, Dz);
                    Cruz c = new Cruz(Px, Py, Pz, Dx, Dy, Dz);

                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Que desea hacer? ");
                        Console.WriteLine("a. Sumar los vectores (A + B)");
                        Console.WriteLine("b. Restar los vectores (A - B)");
                        Console.WriteLine("c. Producto punto los vectores (A * B)");
                        Console.WriteLine("d. Producto cruz de los vectores (A X B)");
                        opcA = Char.Parse(Console.ReadLine());

                        switch (opcA)
                        {
                            case 'a':
                                Vx = s.Calcularx();
                                Vy = s.Calculary();
                                Vz = s.Calcularz();
                                s.Desplegar(Vx, Vy, Vz);
                                break;
                            case 'b':
                                Vx = r.Calcularx();
                                Vy = r.Calculary();
                                Vz = r.Calcularz();
                                r.Desplegar(Vx, Vy, Vz);
                                break;
                            case 'c':
                                Vx = p.Calcularx();
                                Vy = p.Calculary();
                                Vz = p.Calcularz();
                                p.Desplegar(Vx, Vy, Vz);
                                break;
                            case 'd':
                                Vx = c.Calcularx();
                                Vy = c.Calculary();
                                Vz = c.Calcularz();
                                c.Desplegar(Vx, Vy, Vz);
                                break;
                            default:
                                Console.WriteLine("La opcion " + opcA + " no es una opcion valida");
                                break;
                        }

                        Console.WriteLine("Enter para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Que desea hacer?");
                        Console.WriteLine("a. Seguir usando los mimso vectores");
                        Console.WriteLine("b. Continuar utilizando diferentes vectores");
                        Console.WriteLine("c. Continuar utilizando solo el primer vector y cambiando el segundo");
                        Console.WriteLine("d - z. Cerrar el programa");
                        opcB = Char.Parse(Console.ReadLine());

                        Console.Clear();
                    } while (opcB == 'a');
                } while (opcB == 'c');
            } while (opcB == 'b');
        }
    }
}
