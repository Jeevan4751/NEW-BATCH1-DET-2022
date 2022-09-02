using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_Take
    {
        public static void Main()
        {
            int[] numbers = { 15, 25, 233, 44, 05, 776, 1057, 8, 98, 10 };

            var result = numbers.Take(6);

            Console.WriteLine("Takes the first 6 numbers only:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
    }
}
