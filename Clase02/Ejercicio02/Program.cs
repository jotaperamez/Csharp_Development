using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Enunciado: Sea un numero entero N,
             * indica si tiene 1, 2 o mas digitos.
             */

            //¿que propiedad tienen todos 
            //los numeros de 1 digito?
            //Que la division entera de 
            //cualquier numero y diez
            // es == 0; 

            //Entonces.

            Console.WriteLine("Dado un numero entero,\n capaz de decirte cuantos digitos tiene !");
            Console.WriteLine("¿Empezamos?");
            Console.ReadKey();

            Console.Write("Introduzca un numero: ");
            string numero = Console.ReadLine();
            Console.Write(" ANALIZANDO ... \n");
            Console.Write(getDigitos(numero));
            Console.ReadKey();
        }

        public static string getDigitos(string numero){

           int parse = Convert.ToInt16(numero);

           if (parse / 10 == 0)
           {
               return "El numero " + parse + " tiene 1 cifra.";
           }
           else if (parse / 100 == 0)
           {
               return "El numero " + parse + " tiene 2 cifras";
           }
           else
           {
               return "El numero " + parse + " tiene mas de dos cifras";
           }
    }
    }
}
