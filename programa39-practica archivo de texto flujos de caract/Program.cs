using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programa39_practica_archivo_de_texto_flujos_de_caract
{

    public class TextoCaracteres
    {
        //campos de la clase
        StreamWriter sw = null; //declaración flujo de escritura
        StreamReader sr = null; //declaración flujo de lectura
        String str;
        //método 1
        public void CrearArchivo(string nombre)
        {
            try
            {
                // Crea flujo de escritura hacia el archivo doc.txt, si el archivo existe sobreescribe su contenido.
                sw = new StreamWriter(nombre + ".txt");
                Console.WriteLine("Escriba las líneas de texto para almacenar en el archivo.\n" + "Finalice cada línea pulsando la tecla<enter>.\n" + "Para finalizar la escritura pulse sólo la tecla <ENTER>.\n");
                // Lee una línea de la entrada estándar
                str = Console.ReadLine();
                // Mientras la cadena str no esté vacía escribe en el archivo
                while (str.Length != 0)
                {
                    // Escribe la línea leída en el archivo
                    sw.WriteLine(str);
                    // Lee la línea siguiente de la entrada estándar
                    str = Console.ReadLine();
                }
            }
            catch (IOException es)
            {
                Console.WriteLine("Mensaje del Error: " + es.Message);
                Console.WriteLine("Ruta del Error: " + es.StackTrace);
            }
            finally
            {
                // Cierra el flujo de escritura
                if (sw != null) sw.Close();
                //escribir mensaje para el finally
            }
        }//fin método creararchivo

        //método 2
        public void LeerArchivo(string nombre)
        {
            try
            {
                // Crea flujo de lectura desde el archivo doc.txt
                sr = new StreamReader(nombre + ".txt");
                // Lee del archivo una línea de texto
                str = sr.ReadLine();
                // Mientras la cadena str no esté vacía lee en el archivo
                while (str != null)
                {
                    // Muestra la línea leída y lee la línea siguiente del archivo
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
            }
            catch (IOException le)
            {
                Console.WriteLine("Mensaje del Error: " + le.Message);
                Console.WriteLine("Ruta del Error: " + le.StackTrace);
            }
            finally
            {
                // Cierra el flujo de lectura
                if (sr != null) sr.Close();
                Console.WriteLine("Programa creado por: Emiliano García Cordero");
            }
        }//fin método leerarchivo
    }//fin clase textocaracteres

    class Program
    {
        static void Main(string[] args)
        {

            //declaración de variables
            char opc = 'a';
            string nombre;

            Console.Clear();
            TextoCaracteres te = new TextoCaracteres();
            do
            {
                Console.WriteLine("MENU ARCHIVO TEXTO CHAR");
                Console.WriteLine("a) Escribir un Archivo");
                Console.WriteLine("b) Leer un Archivo");
                Console.WriteLine("c) Salir del programa");
                Console.Write("Alimente su respuesta: ");
                try
                {
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
                }
                catch (FormatException q)
                {
                    Console.WriteLine("\nError : " + q.Message);

                    Console.WriteLine("\nRuta : " + q.StackTrace);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey();
                }
            } while (opc != 'c');

        }
    }
}
