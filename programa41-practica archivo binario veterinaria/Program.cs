using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programa41_practica_archivo_binario_veterinaria
{
    class ArchivoBinarioVeterinaria
    {
        //declaracion de flujos
        BinaryWriter bw = null; //flujo salida - escritura de datos
        BinaryReader br = null; //flujo entrada - lectura de datos
                                //campos de la clase
        string Nombre, Raza, Color, Padecimiento, NArchivo;
        int Edad;
        short DiasHospitalizado;
        float CostoXDia;
        public void CrearArchivo(string Archivo)
        {
            NArchivo = Archivo;
            char resp; //variable local método
            try
            {
                //creación del flujo para escribir datos al archivo
                bw = new BinaryWriter(new FileStream(Archivo, FileMode.Create, FileAccess.Write));
                
                //captura de datos
                do
                {
                    Console.Clear();

                    Console.Write("Nombre de la mascota: ");
                    Nombre = Console.ReadLine();
                    Console.Write("Raza de la mascota: ");
                    Raza = Console.ReadLine();
                    Console.Write("Color de la mascota: ");
                    Color = Console.ReadLine();
                    Console.Write("Edad de la mascota: ");
                    Edad = Int32.Parse(Console.ReadLine());
                    Console.Write("Padecimeinto de la mascota: ");
                    Padecimiento = Console.ReadLine();
                    Console.Write("Dias hospitalizado: ");
                    DiasHospitalizado = Int16.Parse(Console.ReadLine());
                    Console.Write("Costo por dia hospitalizado: ");
                    CostoXDia = Single.Parse(Console.ReadLine());
                    
                    //escribe los datos al archivo en disco
                    bw.Write(Nombre);
                    bw.Write(Raza);
                    bw.Write(Color);
                    bw.Write(Edad);
                    bw.Write(Padecimiento);
                    bw.Write(DiasHospitalizado);
                    bw.Write(CostoXDia);
                    Console.Write("\n\nDeseas Almacenar otro Registro (s/n) ? ");
                    resp = Char.Parse(Console.ReadLine());
                } while ((resp == 's') || (resp == 'S'));
            }
            catch (IOException es)
            {
                Console.WriteLine("\nError : " + es.Message);
                Console.WriteLine("\nRuta : " + es.StackTrace);
            }
            catch (FormatException fo)
            {
                Console.WriteLine("\nError : " + fo.Message);
                Console.WriteLine("\nRuta : " + fo.StackTrace);
            }
            finally
            {
                if (bw != null) bw.Close(); //cierra flujo escritura
                Console.Write("\nPresione <enter> para terminar la Escritura de Datos y regresar al Menu.");
                Console.ReadKey();
            }
        }
        public void MostrarArchivo(string Archivo)
        {
            NArchivo = Archivo;
            try
            {
                //verifica si existe el archivo
                if (File.Exists(Archivo))
                {
                    //creación flujo para leer datos del archivo
                    br = new BinaryReader(new FileStream(Archivo, FileMode.Open, FileAccess.Read));
                    //despliegue de datos en pantalla

                    Console.Clear();
                    do
                    {
                        //lectura de registros mientras no llegue al EndOfFile
                        Nombre = br.ReadString();
                        Raza = br.ReadString();
                        Color = br.ReadString();
                        Edad = br.ReadInt32();
                        Padecimiento = br.ReadString();
                        DiasHospitalizado = br.ReadInt16();
                        CostoXDia = br.ReadSingle();
                        //muestra los datos en pantalla

                        Console.WriteLine("Nombre de la mascotoa :" + Nombre);
                        Console.WriteLine("Raza de la mascota :" + Raza);
                        Console.WriteLine("Color de la mascota :" + Color);
                        Console.WriteLine("Edad de la mascota :" + Edad);
                        Console.WriteLine("Dias hospitalizado :" + DiasHospitalizado);
                        Console.WriteLine("Costo por dia hospitalizado :{0:C}", CostoXDia);
                        Console.WriteLine("Pago total por hospitalizacion :{0:C}", (DiasHospitalizado * CostoXDia));
                        Console.WriteLine("\n");
                    } while (true);
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("\n\nEl Archivo " + Archivo + " No Existe en el Disco!!");
                    Console.Write("\nPresione <enter> para Continuar...");
                    Console.ReadKey();
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("\n\nFin del Listado de Mascotas");
                Console.Write("\nPresione <enter> para Continuar...");
                Console.ReadKey();
            }
            finally
            {
                if (br != null) br.Close(); //cierra flujo lectura
                Console.Write("\nPresione <enter> para terminar la Lectura de Datos y regresar al Menu.");
                Console.ReadKey();
            }
        }
        ~ArchivoBinarioVeterinaria()
        {
            Console.WriteLine("\nMemoria Liberada Archivo Binario: " + this.NArchivo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //declaración variables auxiliares
            string Archi = null;
            char opc = 'a';
            //creación del objeto
            ArchivoBinarioVeterinaria Vet = new ArchivoBinarioVeterinaria();
            //Menu de Opciones
            
            do
            {
                Console.Clear();
                Console.WriteLine("\n MENU DE VETERINARIA");
                Console.WriteLine("a) Crear el Archivo");
                Console.WriteLine("b) Leer el Archivo");
                Console.WriteLine("c) Salida del Programa");
                Console.Write("Alimente su opcion: ");
                try
                {

                    opc = Char.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 'a':
                            //bloque de escritura
                            try
                            {
                                //captura nombre archivo

                                Console.Write("\nAlimenta el Nombre del Archivo a Crear: "); Archi = Console.ReadLine();
                                //verifica si esxiste el archivo

                                char resp = 's';
                                if (File.Exists(Archi))

                                {
                                    Console.Write("\nEl archivo ya existe, deseas sobreescribirlo (s / n) ? ");
                                    resp = Char.Parse(Console.ReadLine());
                                }
                                if ((resp == 's') || (resp == 'S'))
                                    Vet.CrearArchivo(Archi);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("\nError : " + e.Message);

                                Console.WriteLine("\nRuta : " +

                                e.StackTrace);
                            }
                            break;
                        case 'b':
                            //bloque de lectura

                            try
                            {
                                //captura nombre archivo

                                Console.Write("\nAlimenta el nombre del archivo que deseas leer: ");
                                Archi = Console.ReadLine();
                                Vet.MostrarArchivo(Archi);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("\nError : " + e.Message);

                                Console.WriteLine("\nRuta : " + e.StackTrace);
                            }
                            break;
                        case 'c':
                            Console.Write("\nPresione enter para salir del Programa.");
                            Console.ReadKey();

                            break;
                        default:
                            Console.Write("\nNo existe esta opcion, presione enter para continuar...");
                            Console.ReadKey();

                            break;
                    }
                }
                catch (FormatException v)
                {
                    Console.WriteLine("\nError : " + v.Message);

                    Console.WriteLine("\nRuta : " + v.StackTrace);
                    Console.WriteLine("Pulsa enter para continuar");
                    Console.ReadKey();
                }
                finally
                {
                }
            } while (opc != 'c');
        }
    }
}
