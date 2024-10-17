using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa7_ejemplo_procedimiento
{
    class Program
    {
        private void Procedimientos()
        {
            //Programa que suma, resta, multiplica y divide dos numeros
            //Declaracion de variables
            float N1, N2;

            Console.Write("¿Cual es su primer numero? ");
            N1 = Single.Parse(Console.ReadLine());

            Console.Write("¿Cual es su segundo numero? ");
            N2 = Single.Parse(Console.ReadLine());

            //LLamada a procedimiento S()
            S(N1, N2);

            //LLamada a procedimiento R()
            R(N1, N2);

            //LLamada a procedimiento M()
            M(N1, N2);

            //LLamada a procedimiento D()
            D(N1, N2);

            Console.WriteLine("Pulse enter para salir del programa");
            Console.ReadKey();
        }

        //Creado para la suma de los dos numeros
        void S(float SN1, float SN2)
        {
            //Declaracion de variable local
            float SR;

            //Suma de dos numeros
            SR = SN1 + SN2;

            //Salida de resultados
            Console.WriteLine("El resultado de la suma es: " + SR);
        }

        //Creado para la resta de los dos numeros
        void R(float RN1, float RN2)
        {
            //Declaracion de variable local
            float RR;

            //Resta de dos numeros
            RR = RN1 - RN2;

            //Salida de resultado
            Console.WriteLine("El resultado de la resta es " + RR);
        }

        //Creado para la multiplicacion de dos numeros
        void M(float MN1, float MN2)
        {
            //Declaracion de variable local
            float MR;

            //Multiplicacion de dos numeros
            MR = MN1 * MN2;

            //Salida de resultados
            Console.WriteLine("El resultado de la multiplicacion es " + MR);
        }

        //Creado para la division de dos numeros
        void D(float DN1, float DN2)
        {
            //Delcaracion de variable local
            float DR;

            //Division de dos numeros
            DR = DN1 / DN2;

            //Salida de resultados
            Console.WriteLine("El resultado de la division es " + DR);
        }

        static void Main(string[] args)
        {
            Program repre = new Program();
            repre.Procedimientos();
        }
    }
}
