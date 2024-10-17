using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa16_practica_clase_cliente
{
    class Program
    {
        public class Cliente
        {
            //Campos de clase
            string nombre, direccion;
            float numeroCliente, telefono;

            //Constructor
            public Cliente(string nombre, string direccion, float numeroCliente, float telefono)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                this.numeroCliente = numeroCliente;
                this.telefono = telefono;
            }

            //Metodos de clase
            public float Calcular(float precioProducto, int cantidadVendida)
            {
                float total;
                total = precioProducto * cantidadVendida;
                return total;
            }

            //Despliegue de resultados
            public void DesplegarVenta(string nombrePro, float Precio, int cantVe, float Total)
            {
                Console.WriteLine("Nombre del cliente: "+ nombre);
                Console.WriteLine("Direccion: "+ direccion);
                Console.WriteLine("Numero del cliente: "+ numeroCliente);
                Console.WriteLine("Telefono: "+ telefono);
                Console.WriteLine("Nombre del producto: "+ nombrePro);
                Console.WriteLine("Precio del producto: "+ Precio);
                Console.WriteLine("Cantidad comprada: "+ cantVe);
                Console.WriteLine("Total: {0:c2}", Total);
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            string nom, dire, nomPr;
            float num, tele, pre, T;
            int cantVe;

            //Capturacion de datos del cliente
            Console.Write("Nombre del cliente? ");
            nom = Console.ReadLine();
            Console.Write("Direcion del cliente? ");
            dire = Console.ReadLine();
            Console.Write("Numero de telefono? ");
            tele = Single.Parse(Console.ReadLine());
            Console.Write("Numero del cliente? ");
            num = Single.Parse(Console.ReadLine());
            Console.Clear();
            
            //Creacion de objecto
            Cliente cli = new Cliente(nom, dire, num, tele);

            //Capturacion de datos del producto
            Console.Write("Nombre del producto: ");
            nomPr = Console.ReadLine();
            Console.Write("Precio del producto: ");
            pre = Single.Parse(Console.ReadLine());
            Console.Write("Cantidad vendida del producto: ");
            cantVe = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            //Ejecucion de metodos
            T = cli.Calcular(pre, cantVe);
            cli.DesplegarVenta(nomPr, pre, cantVe, T);
            
            //Salida del programa
            Console.WriteLine("Pulse enter para terminar el proceso");
            Console.ReadKey();
        }
    }
}
