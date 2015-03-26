using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSelect
{
    class Program
    {
        static void Main()
        {
            //Create the data source
            List<int> Scores = new List<int>() { 97, 92, 81, 60 };

            // Create the query.
            IEnumerable<int> queryHighScores =
                from score in Scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in queryHighScores)
            {
                Console.Write(i + " ");
                Console.ReadKey();
            }
        }
    }
}
