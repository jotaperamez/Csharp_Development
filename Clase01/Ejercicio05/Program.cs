using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido el ejercicio 04 en References


namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Enunciado: Dadas dos horas diferentes expresadas en Horas, minutos
             * y segundos, devolver la diferencia en segundos de ambas.
             */

            Console.Write("Vamos a restar 2 horas direfentes: \n\n\t La primera sera: 6:45:35 \n\t y la segunda: 3:12:59 \n\n el resultado es: " + (parseAndOperation(6, 45, 35) - parseAndOperation(3, 12, 59))+" segundos es la diferencia");
            Console.ReadKey();
        }
        //Este metodo pasará un formato "HH:mm:ss" a "Segundos"
        public static int parseAndOperation(int hora, int minuto, int segundos)
        {
            segundos += hora * 3600;
            segundos += minuto * 60;
            return segundos;
        }
    }
}
