using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_Assignment
    {
        //In a array of names, find the names which contains 'O'
        static void Sample_Contains()
        {
            string[] names = {"John","Peter","Jacob", "Harry","Jackson" };

            var result = names.Contains("O");

            Console.WriteLine("sequence contains the value :");
            Console.WriteLine(result);
        }


        //In a array of names, find the names which has max no of character length
        static void Sample_MaxLength()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var result = names.Max();

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }

        //For data source     string[] words1 = { "believe", "relief", "receipt", "field" }  display the output
        //like below  believe--7  ,relief--6  ,receipt--7  ,field—5.


        static void Sample_Length()
        {
            string[] names = { "believe", "relief", "receipt", "field" };
            var result = names.Length;
            Console.WriteLine($" names", "+", "--", "+", names.Length);

        }

        //For the data source  string[] words = { "blueberry", "blackberry", "abacus"             };
        //Display result as (reverse of the string)

        static void Sample_Reverse_Lambda()
        {
            string[] names = { "blueberry", "blackberry", "abacus"  };

            var result = names.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (string Name in result)
                Console.WriteLine(Name);
        }


        //Int[] numbers={1,3,2,0}, string[]={‘C#’, ‘SQL’, ‘LINQ’, ‘Java’}
        //Display the result as   SQL,  Java,  LINQ,  C#


        static void Sample_ThenBy_()
        {
            string[] words = { "C#", "SQL", "LINQ", "Java" };

            var result = words.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string WORDS in result)
                Console.WriteLine(WORDS);
        }


    }



}
