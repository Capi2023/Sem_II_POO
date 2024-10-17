using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCordero_U3
{
    class Program
    {
        public class Productos
        {
            //Atributos de la clase
            public float PrecioProducto;
            public int NumeroProducto, UnidadesExistencia;
            public string NombreProducto;

            //Contructor
            public Productos(int NumeroProducto, string NombreProducto, float PrecioProducto, int UnidadesExistencia)
            {
                this.NumeroProducto = NumeroProducto;
                this.NombreProducto = NombreProducto;
                this.PrecioProducto = PrecioProducto;
                this.UnidadesExistencia = UnidadesExistencia;
            }

            //Metodos
            public virtual float Calcular()
            {
                return 0;
            }

            public void Imprimir()
            {
            }

            //Destructor
            ~Productos()
            {
                Console.WriteLine("Memoria Liberada Objeto Base Productos");
                Console.ReadLine();
            }
        }

        public class Ventas : Productos
        {
            public int UnidadesVendidas;

            //Constructor
            public Ventas(int UnidadesVendidas, int NumeroProducto, string NombreProducto, float PrecioProducto, int UnidadesExistencia)
            : base(NumeroProducto, NombreProducto, PrecioProducto, UnidadesExistencia)
            {
                this.UnidadesVendidas = UnidadesVendidas;
            }

            //Metodos
            public override float Calcular()
            {
                base.Calcular();
                UnidadesExistencia = UnidadesExistencia - UnidadesVendidas;
                return UnidadesVendidas * PrecioProducto;
            }

            new public void Imprimir()
            {
                Console.WriteLine("Numero del producto: " + NumeroProducto);
                Console.WriteLine("Nombre del producto: " + NombreProducto);
                Console.WriteLine("Precio del producto: {0:c2}", PrecioProducto);
                Console.WriteLine("Unidades vendidas: " + UnidadesVendidas);
                Console.WriteLine("Unidades existentes: " + UnidadesExistencia);
                Console.WriteLine("Venta total: {0:c2}", Calcular());
            }

            //Desctructor
            ~Ventas()
            {
                Console.WriteLine("Memoria Liberada Objeto Derivado Ventas");
                Console.ReadLine();
            }
        }

        public class Compras : Productos
        {
            public int UnidadesCompradas;
            //Contructor
            public Compras(int UnidadesCompradas, int NumeroProducto, string NombreProducto, float PrecioProducto, int UnidadesExistencia)
            : base(NumeroProducto, NombreProducto, PrecioProducto, UnidadesExistencia)
            {
                this.UnidadesCompradas = UnidadesCompradas;
            }

            //Metodos
            public override float Calcular()
            {
                base.Calcular();
                UnidadesExistencia = UnidadesExistencia + UnidadesCompradas;
                return UnidadesCompradas * PrecioProducto;
            }

            new public void Imprimir()
            {
                Console.WriteLine("Numero del producto: " + NumeroProducto);
                Console.WriteLine("Nombre del producto: " + NombreProducto);
                Console.WriteLine("Precio del producto: {0:c2}", PrecioProducto);
                Console.WriteLine("Unidades compradas: " + UnidadesCompradas);
                Console.WriteLine("Unidades existentes: " + UnidadesExistencia);
                Console.WriteLine("Compra total: {0:c2}", Calcular());
            }

            //Destructor
            ~Compras()
            {
                Console.WriteLine("Memoria Liberada Objeto Derviado Compras");
            }
        }

        static void Main(string[] args)
        {
            //Declaracion de variables
            float PrecioProducto;
            int NumeroProducto, UnidadesExistencia, UnidadesVendidas, UnidadesCompradas;
            string NombreProducto;

            //Asignacion de valores
            Console.Write("Cual es el numero del producto: ");
            NumeroProducto = Int32.Parse(Console.ReadLine());
            Console.Write("Nombre del producto: ");
            NombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: ");
            PrecioProducto = Single.Parse(Console.ReadLine());
            Console.Write("Unidades en existencia: ");
            UnidadesExistencia = Int32.Parse(Console.ReadLine());
            Console.Clear();

            //Creacion de objecto y parametros para clase base
            Productos pro = new Productos(NumeroProducto, NombreProducto, PrecioProducto, UnidadesExistencia);

            //Asignacion de valores para clase derivada Venta
            Console.Write("Unidades vendidas: ");
            UnidadesVendidas = Int32.Parse(Console.ReadLine());
            Console.Clear();

            //Creacion de objectos y parametros para clase derivada Ventas
            Ventas ven = new Ventas(UnidadesVendidas, NumeroProducto, NombreProducto, PrecioProducto, UnidadesExistencia);

            //Metodos de la clase dervida Ventas
            ven.Calcular();
            ven.Imprimir();
            Console.WriteLine("Pulsa enter para continuar con la compra");
            Console.ReadKey();
            Console.Clear();

            //Asignacion de valores para clase derivada Compras
            Console.Write("Unidades compradas: ");
            UnidadesCompradas = Int32.Parse(Console.ReadLine());
            Console.Clear();

            //Creacion de objectos y parametros para clase derivada Compras
            Compras co = new Compras(UnidadesCompradas, NumeroProducto, NombreProducto, PrecioProducto, UnidadesExistencia);

            //Metodos de la clase dervida Compras
            co.Calcular();
            co.Imprimir();

            Console.WriteLine("Pulsa enter para cerrar el programa");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
