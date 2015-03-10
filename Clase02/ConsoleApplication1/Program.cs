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
            /*
             * Enunciado: sean los enteros 
             * x=2, y=5, z=13, a=true, b=false
             * comprobar el comportamiento de los 
             * operadores y experesiones logicos basicos.
             * 
             */


              //Variables
            int x = 2;
            int y = 5;
            int z = 13;
            bool a = true;
            bool b = false;

            //Salida por consola
            Console.WriteLine("[2 - 5]\n" + testInt(x, y) + "\n\n[2 - 13]\n" + testInt(x, z) + "\n\n[5 - 13]\n" + testInt(y, z));
            Console.WriteLine("\n[TRUE - FALSE]\n"+textBool(a, b));
            Console.ReadKey();

        }

            /**
             * metodo para testear enteros
             */
            public static string testInt(int a, int b){
                return "( "+a+" == "+b+" ) => " + (a==b)+
                    "\n( "+a+" != "+b+" ) => " + (a!=b)+
                    "\n( "+a+" < "+b+" ) => " + (a<b)+
                    "\n( "+a+" > "+b+" ) => " + (a>b);
            }
            /**
            * metodo para testear booleanos
            */
            public static string textBool(bool a, bool b)
            {
                return "( " + a + " || " + b + " ) => " + (a || b) +
                    "\n( " + a + " && " + b + " ) => " + (a && b);
            } 
         
        }
    }

