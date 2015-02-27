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
             * Enunciado: Nos vamos de compras al super y compramos
             * 2 kg de manzanas y 1.5 kg de peras.
             * El precio de ambos productos es de 0.99 €/kg
             * ¿Cuanto cuesta la compra total? 
             */

            double kgManzana = 2;
            double kgPeras = 1.5;
            double proporcionEuroKg = 0.99;
            Console.WriteLine("La compra cuesta: " + (kgManzana * proporcionEuroKg + kgPeras * proporcionEuroKg));
            Console.ReadKey();

        }
    }
}
