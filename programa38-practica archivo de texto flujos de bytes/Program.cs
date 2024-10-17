using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace programa38_practica_archivo_de_texto_flujos_de_bytes
{
    public class TextoBytes
    {
        //campos de la clase
        FileStream fs = null; //declaración flujo salida – escritura
        FileStream fe = null; //declaración flujo entrada - lectura
        byte[] bBuffer = new byte[81]; //arreglo tipo byte
        char[] cBuffer = new char[81]; //arreglo tipo char
        int nbytes = 0, car;
        //método 1
        public void CrearArchivo(string nombre)
        {
            try
            {
                // Crea un flujo hacia el archivo texto.txt
                fs = new FileStream(nombre + ".txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo, al finalizar presione <enter>:");
                while ((car = Console.Read()) != '\n' && (nbytes < bBuffer.Length))
                {
                    bBuffer[nbytes] = (byte)car; //convierte en byte el carácter leído
                    nbytes++; //incrementa contar de bytes
                }
                // Escribe la línea de texto en el archivo.
                fs.Write(bBuffer, 0, nbytes);
            }
            catch (IOException es)
            {
                Console.WriteLine("Mensaje del Error: " + es.Message);
                Console.WriteLine("Ruta del Error: " + es.StackTrace);
            }
            finally
            {
                if (fs != null) fs.Close(); //cierra el flujo de escritura
                Console.WriteLine("Programa creado por: Emiliano García Cordero");
            }
        }//fin método creararchivo

        public void LeerArchivo(string nombre)
        {
            try
            {
                // Crea un flujo desde el archivo texto.txt
                fe = new FileStream(nombre + ".txt", FileMode.Open, FileAccess.Read);
                // Lee del archivo una línea de texto
                nbytes = fe.Read(bBuffer, 0, 81);
                // Crea un objeto string con el texto leído
                Array.Copy(bBuffer, cBuffer, bBuffer.Length);
                String str = new String(cBuffer, 0, nbytes);
                // Muestra el texto leído en pantalla
                Console.WriteLine("\nNOMBRE DEL ARCHIVO:");
                Console.WriteLine(nombre);
                Console.WriteLine("\nCONTENIDO DEL ARCHIVO EN DISCO:");
                Console.WriteLine(str);
            }
            catch (IOException le)
            {
                Console.WriteLine("Mensaje del Error: " + le.Message);
                Console.WriteLine("Ruta del Error: " + le.StackTrace);
            }
            finally
            {
                if (fe != null) fe.Close(); //cierra el flujo de lectura
                                            // escribir mensaje deseado para el finally.
            }
        }// fin método leerarchivo

        ~TextoBytes()
        {
            Console.WriteLine("Memoria Liberada Clase TextoBytes");
        }
    }//fin clase textobytes

    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            char opc;
            string nombre;

            Console.Clear();
            TextoBytes te = new TextoBytes();
            do
            {
                Console.WriteLine("MENU ARCHIVO TEXTO BYTES");
                Console.WriteLine("a) Escribir un Archivo");
                Console.WriteLine("b) Leer un Archivo");
                Console.WriteLine("c) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                opc = Char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'a':
                        Console.WriteLine("Cual es el nombre del archivo? ");
                        nombre = Console.ReadLine();
                        te.CrearArchivo(nombre);
                        Console.Write("Pulsa enter para continuar");
                        Console.ReadKey();
                        break;
                    case 'b':
                        Console.WriteLine("Cual es el nombre del archivo? ");
                        nombre = Console.ReadLine();
                        te.LeerArchivo(nombre);
                        Console.Write("Pulsa enter para continuar");
                        Console.ReadKey();
                        break;
                    case 'c':
                        Console.Clear();
                        Console.WriteLine("Pulsa enter para salir del programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("La opcion " + opc + " no es una opcion valida");
                        Console.WriteLine("Pulsa enter para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opc != 'c');
        }
    }
}
