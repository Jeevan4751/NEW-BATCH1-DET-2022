using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQOrderBy
    {
        public static void Main()
        {
            // Sample_OrderBy_Lambda_numbers()


            /*  int[] numbers = { 03, 09, 25, 16};

               var result = numbers.OrderBy(n => n);

               Console.WriteLine("Ordered list of numbers:");
               foreach (int number in result)
                  Console.WriteLine(number);*/


            //Sample_OrderBy_Lambda_Dates()
            var dates = new DateTime[]
            {
             new DateTime(2000, 2, 15),
             new DateTime(1999, 11, 14),
             new DateTime(2004, 8, 23),
             };

            var result = dates.OrderBy(d => d);

            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));



        }
    }
}
