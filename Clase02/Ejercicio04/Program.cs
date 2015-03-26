using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * Enunciado: Crear un menu de opciones con la sentencia switch.
             * Por ejemplo, un minitest con preguntas a,b,c u dependendiendo
             * de la opcion seleccionada, se mostrara un mensaje diferente
             * por pantalla.
             */

            /**
             * Voy a explicar de forma sencilla como utilizar la estructura switch
             * respondiendo a una pregunta que yo mismo formularé.
             */

            
            //Formulamos la pregunta
            Console.WriteLine("En la lengua 'klingon'. ¿ Como se escribiria la frase 'Hoy es un buen dia para morir ?' :");
            //Respuestas posibles
            Console.WriteLine("\n1. PhOOIstaj 'Quelte ahHM.\t 2.Bliie'  TTratHH\n\n3.Heghlu'meH QaQ jajvam \t 4.Maritrini.\n");
            //Guardamos la respuesta en memoria
            string respuesta = Console.ReadLine();

            //Actuamos en funcion a la respuesta.
            switch (respuesta)
            {
                case "1": Console.WriteLine("¡ Mal ! La respuesta correcta era la numero 3");
                    break;
                case "2": Console.WriteLine("¡ Mal ! La respuesta correcta era la numero 3");
                    break;
                case "3": Console.WriteLine("Correcto");
                    break;
                case "4": Console.WriteLine("¡ Mal ! La respuesta correcta era la numero 3");
                    break;
            
            }

            Console.ReadKey();

        }
    }
}
