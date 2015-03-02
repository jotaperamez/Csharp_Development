
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosClase1
{
     public class Program
    {
           public static void Main(string[] args)
        {

            /*
             * Enunciado: dado un numero en segundos,
             * devolver por pantalla el equivalente a
             * horas, minutos y segundos.
             */

            //variables
            string valorTeclado;

            //Peticion de valor
           Console.Write("Introduzca un tiempo en segundos para su 'formato' a HH:mm:ss : ");
           valorTeclado = Console.ReadLine();
            //salida
           Console.WriteLine("\ntransformando... \n");
           Console.WriteLine("La salida ya formateada seria: "+parseSeconds(valorTeclado));
           Console.ReadKey();

            

        }
        //Metodo que devuelve los segundo parseados a Hora:Minutos:Segundos
        //No controla excepciones.
        public static string parseSeconds(string toParse)
        {
            
            TimeSpan tiempo = TimeSpan.FromSeconds(Convert.ToDouble(toParse));
            string horas = tiempo.Hours.ToString();
            string minutos = tiempo.Minutes.ToString();
            string segundos = tiempo.Seconds.ToString();
            string formatoHora = string.Format("{0:D2}:{1:D2}:{2:D2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds);

                return formatoHora;
        }
    }
}
