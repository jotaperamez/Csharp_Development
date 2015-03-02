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


            Console.WriteLine(parseAndOperation(1, 1, 1));
            Console.WriteLine(parseAndOperation(1, 1, 2));
            Console.WriteLine(parseAndOperation(1, 1, 1) - parseAndOperation(1, 1, 2));
            Console.ReadKey();

        }
        public static int parseAndOperation(int hora, int minuto, int segundos)
        {
            segundos += hora * 3600;
            segundos += minuto * 60;
            return segundos;
        }
    }
}
