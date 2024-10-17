using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GarciaCordero_U6
{
    class ArchivoBinarioClientes
    {
        //Declaracion de flujos
        BinaryWriter bw = null; //Flujo salida - escritura de datos
        BinaryReader br = null; //Flujo entrada - lectura de datos
        //Campos de la clase
        string Nombre, RFC, Domicilio, Correo, NArchi;
        int NumCliente;
        float Adeudo, PagoM;
        long Telefono;

        public void CrearA(string Archivo)
        {
            NArchi = Archivo;
            char res; //Variable local método
            try
            {
                //Creación del flujo para escribir datos al archivo
                bw = new BinaryWriter(new FileStream(Archivo, FileMode.Create, FileAccess.Write));

                //Captura de datos
                do
                {
                    Console.Clear();
                    Console.Write("Numero del cliente: ");
                    NumCliente = Int32.Parse(Console.ReadLine());
                    Console.Write("Nombre del cliente: ");
                    Nombre = Console.ReadLine();
                    Console.Write("RFC del cliente: ");
                    RFC = Console.ReadLine();
                    Console.Write("Domicilio del cliente: ");
                    Domicilio = Console.ReadLine();
                    Console.Write("Telefono del cliente: ");
                    Telefono = Int64.Parse(Console.ReadLine());
                    Console.Write("Correo electronico: ");
                    Correo = Console.ReadLine();
                    Console.Write("Adeudo total del cliente: ");
                    Adeudo = Single.Parse(Console.ReadLine());
                    Console.Write("Pago mensual del cliente: ");
                    PagoM = Single.Parse(Console.ReadLine());

                    //Escribe los datos al archivo
                    bw.Write(NumCliente);
                    bw.Write(Nombre);
                    bw.Write(RFC);
                    bw.Write(Domicilio);
                    bw.Write(Telefono);
                    bw.Write(Correo);
                    bw.Write(Adeudo);
                    bw.Write(PagoM);

                    Console.Write("\n\nDeseas almacenar otro registro? (s / n)");
                    res = Char.Parse(Console.ReadLine());

                } while ((res == 'S') || (res == 's'));
            }

            catch (IOException a)
            {
                Console.WriteLine("\nError: " + a.Message);
                Console.WriteLine("\nRuta: " + a.StackTrace);
            }
            catch (FormatException b)
            {
                Console.WriteLine("\nError: " + b.Message);
                Console.WriteLine("\nRuta: " + b.StackTrace);
            }

            finally
            {
                if (bw != null)bw.Close();
                Console.Write("\nPresione enter para terminar la escritura de datos y regresar al menu");
                Console.ReadKey();
            }
        }

        public void MostrarA(string Archivo)
        {
            NArchi = Archivo;
            try
            {
                //Verifica si existe el archivo
                if (File.Exists(Archivo))
                {
                    //Creación flujo para leer datos del archivo
                    br = new BinaryReader(new FileStream(Archivo, FileMode.Open, FileAccess.Read));
                    
                    //Despliegue de datos en pantalla
                    Console.Clear();
                    do
                    {
                        //Lectura de registros mientras no llegue al EndOfFile
                        NumCliente = br.ReadInt32();
                        Nombre = br.ReadString();
                        RFC = br.ReadString();
                        Domicilio = br.ReadString();
                        Telefono = br.ReadInt64();
                        Correo = br.ReadString();
                        Adeudo = br.ReadSingle();
                        PagoM = br.ReadSingle();

                        //Muestra los datos en pantalla
                        Console.WriteLine("Numero del cliente: " + NumCliente);
                        Console.WriteLine("Nombre del cliente: " + Nombre);
                        Console.WriteLine("RFC del cliente: " + RFC);
                        Console.WriteLine("Domicilio del cliente: " + Domicilio);
                        Console.WriteLine("Telefono del cliente: " + Telefono);
                        Console.WriteLine("Correo electronico: " + Correo);
                        Console.WriteLine("Adeudo total del cliente: :{0:C}", Adeudo);
                        Console.WriteLine("IVA: :{0:C}", ((Adeudo) * .08) + (Adeudo));
                        Console.WriteLine("Pago mensual: :{0:C}", PagoM);
                        Console.WriteLine("Saldo total: :{0:C}", ((Adeudo - PagoM) * .08) + (Adeudo - PagoM));
                        Console.WriteLine("\n");
                    } while (true);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\nEl archivo " + Archivo + " no existe");
                    Console.Write("\nPresione enter para continuar");
                    Console.ReadKey();
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("\n\nFin del listado de clientes");
                Console.Write("\nPresione enter para continuar");
                Console.ReadKey();
            }

            finally
            {
                if (br != null) br.Close(); //Cierra flujo lectura
                Console.Write("\nPresione enter para terminar la lectura de datos y regresar al menu");
                Console.ReadKey();
            }
        }
        ~ArchivoBinarioClientes()
        {
            Console.WriteLine("\nMemoria Liberada Archivo Binario: " + this.NArchi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Declaración variables auxiliares
            string Archi = null;
            char opc = 'a';
            
            //Creación del objeto
            ArchivoBinarioClientes Cli = new ArchivoBinarioClientes();
            
            //Menu de Opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n MENU DE CLIENTES");
                Console.WriteLine("a) Crear el archivo");
                Console.WriteLine("b) Leer el archivo");
                Console.WriteLine("c) Salida del programa");
                Console.Write("Alimente su opcion: ");
                
                try
                {

                    opc = Char.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 'a':
                            //Bloque de escritura
                            try
                            {
                                //Captura nombre archivo
                                Console.Write("\nAlimenta el nombre del archivo que se desea crear: ");
                                Archi = Console.ReadLine();
                                
                                //Verifica si esxiste el archivo
                                char resp = 's';
                                if (File.Exists(Archi))
                                {
                                    Console.Write("\nEl archivo ya existe, deseas sobreescribirlo? (s / n) ");
                                    resp = Char.Parse(Console.ReadLine());
                                }

                                if ((resp == 'S') || (resp == 's'))
                                Cli.CrearA(Archi);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("\nError: " + e.Message);
                                Console.WriteLine("\nRuta: " + e.StackTrace);
                            }
                            break;
                        case 'b':
                            //bloque de lectura
                            try
                            {
                                //captura nombre archivo

                                Console.Write("\nAlimenta el nombre del archivo que se desea leer: ");
                                Archi = Console.ReadLine();
                                Cli.MostrarA(Archi);
                            }
                            catch (IOException r)
                            {
                                Console.WriteLine("\nError : " + r.Message);
                                Console.WriteLine("\nRuta : " + r.StackTrace);
                            }
                            break;
                        case 'c':
                            Console.Write("\nPresione enter para salir del programa");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Write("\nNo existe esta opcion, presione enter para continuar");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException k)
                {
                    Console.WriteLine("\nError: " + k.Message);
                    Console.WriteLine("\nRuta: " + k.StackTrace);
                    Console.WriteLine("Pulsa enter para continuar");
                    Console.ReadKey();
                }
            } while (opc != 'c');
        }
    }
}
