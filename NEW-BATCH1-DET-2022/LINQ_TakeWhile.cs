using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_TakeWhile
    { 
        public static void Main()
        {
            int[] numbers = { 1, 2, 30, 4, 5, 6, 78, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 10);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
    }
}
