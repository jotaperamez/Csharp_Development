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
             * Enunciado: Vamos a interacturas un poco con el
             * programa, ahora, en vez de fijar la compra
             * previaente le dejaremos al usuario escribir
             * dicha cifra por consola y en funcion de ello se
             * mostrara el resultado correspondiente.
             */

            //Introducir los KG de manzanas por teclado
           
            Console.Write("¿Cuantos kilos de manzanas quieres comprar?: ");
            string kgManzanas = Console.ReadLine();
            double auxManzanas = Convert.ToDouble(kgManzanas);

            //Introducir los KG de peras por teclado
            Console.Write("¿Cuantos kilos de peras quieres comprar?: ");
            string kgPeras = Console.ReadLine();
            double auxPeras = Convert.ToDouble(kgPeras);

            //Resultado de la compra
            Console.WriteLine("La compra total\n"+kgManzanas+" Kg de Manzanas\n"+ kgPeras+" kg de Peras\n Total: "+(auxManzanas*0.99+auxPeras*0.99));
            Console.ReadKey();
            

        }
    }
}
