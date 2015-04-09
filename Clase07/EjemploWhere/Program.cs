using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWhere
{
    class Program
    {
        static void Main()
        {
            // Simple data source. Arrays support IEnumerable<T>.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Simple query with one predicate in where clause.
            var queryLowNums =
                from num in numbers
                where num < 5 || num > 7
                select num;

            // Execute the query.
            foreach (var s in queryLowNums)
            {
                Console.Write(s.ToString() + " ");
                Console.ReadKey();
            }
            
        }
    }
}
