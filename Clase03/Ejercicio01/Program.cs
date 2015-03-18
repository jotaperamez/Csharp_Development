using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {

     static void Main(string[] args)
         {
            Console.WriteLine("Escribe un número");
            String numero = Console.ReadLine();
            int numero2 = Convert.ToInt32(numero);
            multiplosSinceros(numero2);
            Console.ReadLine(); 
        }

       static Boolean esSincero(int posibleSincero, int numero)
{
            int suma=0;

            while(posibleSincero!=0){
                suma+= posibleSincero %10;
                posibleSincero /= 10;

                Console.WriteLine("suma= "+suma);
                Console.WriteLine("PS= " + posibleSincero);
            }
            return suma == numero;
 }

       static void multiplosSinceros(int numero)
       {
           int i = 1;
           int posibleMS = 1;
           while (i <= 3)
           {
               if (esSincero(posibleMS, numero) && posibleMS % numero == 0)
               {
                   Console.WriteLine(posibleMS);
                   i++;
               }
               posibleMS++;
           }
       }
       
    }
}

