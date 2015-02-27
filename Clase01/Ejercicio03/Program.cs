using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Enunciado: programa que lee 2 numeros enteros,
             * los suma, los resta y muestra por pantalla el
             * resultado de ambas operaciones
             */

            //Variables
            string numero1;
            string numero2;

            //Lectura de valores por teclado
            Console.Write("Introduzca el primer numero: ");
            numero1 = Console.ReadLine();
            Console.Write("Introduzca el segundo numero: ");
            numero2 = Console.ReadLine();

            //Parseo
            int aux1 = Convert.ToInt16(numero1);
            int aux2 = Convert.ToInt16(numero2);

            //Operaciones
            Console.WriteLine("\nSuma: " + (aux1 + aux2));
            Console.WriteLine("\nResta: " + (aux1 - aux2));
            Console.ReadKey();

        }
    }
}
