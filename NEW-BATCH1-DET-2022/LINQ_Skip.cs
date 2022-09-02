using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_Skip

    {
        public static void Main()
        {
            string[] words = { "jeevan", "roja mam", "vinay", "vijay", "MSD", "virat kohli" };

            var result = words.Skip(4);

            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
               Console.WriteLine(word);
        }
    }
}
