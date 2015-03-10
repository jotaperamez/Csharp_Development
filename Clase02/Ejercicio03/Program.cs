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

            Console.WriteLine("Introduce un mes como numero entero: ");
            string mes = Console.ReadLine();

             
            Console.WriteLine("Introduzca un dia del mes correspondiente: ");
            string dia = Console.ReadLine();

            Console.WriteLine("procesando...");

            int a = Convert.ToInt16(mes);
            int b = Convert.ToInt16(dia);

            Console.Write("Solucion: "+existeFecha(a, b));
            Console.ReadKey();
        }

        public static bool existeFecha(int mes, int dia){
            int diasMax = 0;
            switch (mes)
            {
                case 1: diasMax = 31;
                        break;
                case 2: diasMax = 28;
                        break;
                case 3: diasMax = 31;
                        break;
                case 4: diasMax = 30;
                        break;
                case 5: diasMax = 31;
                        break;
                case 6: diasMax = 30;
                        break;
                case 7: diasMax = 31;
                        break;
                case 8: diasMax = 31;
                        break;
                case 9: diasMax = 30;
                        break;
                case 10: diasMax = 31;
                        break;
                case 11: diasMax = 30;
                        break;
                case 12: diasMax = 31;
                        break;
                default: Console.Write("Los meses van del 1 al 12, no lo olvides!");
                        break;
            }
            if ((1 <= mes && mes <= 12) && (dia < diasMax))
            {
                return true;
            }


            return false;

        }
    }
}
