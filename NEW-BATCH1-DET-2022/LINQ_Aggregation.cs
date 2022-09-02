using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_Aggregation
    {
        public static void Main()
        {
            //Sample_Aggregate_Lambda_Simple

            /*
             var numbers = new int[] { 1, 2, 3, 4 };

             var result = numbers.Aggregate((a, b) => a * b);

             Console.WriteLine("Aggregated numbers by multiplication:");
             Console.WriteLine(result);
            */




            //Sample_Average_Lambda

            /*
              int[] numbers = { 10, 10, 10, 10 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
            */





            // Sample_Count_Lambda

            /* 
             string[] names = { "jeevan", "vasu", "ani", };
             var result = names.Count();
             Console.WriteLine("Counting the names ");
             Console.WriteLine(result);
            */


            //Sample_Max_Lambda

            /* 
              int[] numbers = { 10, 77, 18, 07, 9 };
              int result = numbers.Max();
              Console.WriteLine("Highest numbers is");
              Console.WriteLine(result);
            */

            //Sample_Min_Lambda


            /*
            int[] numbers = { 48, 55, 2239, 05, 44, 6, 02 };
            int result = numbers.Min();
            Console.WriteLine("Minimum numbers is");
            Console.WriteLine(result);  
            */

            //Sample_Sum_Lambda


            /*
            int[] numbers = { 11, 44, 1 };
            int result = numbers.Sum();
            Console.WriteLine("The sum of numbers is");
            Console.WriteLine(result);
            */

        }
    }
}
