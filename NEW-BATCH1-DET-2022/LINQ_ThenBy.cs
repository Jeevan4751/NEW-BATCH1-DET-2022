using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_ThenBy
    {
        static void Sample_ThenBy_Lambda()
        {
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                          "Athens", "Beijing", "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Debug.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Debug.WriteLine(capital);
        }
    }
}
