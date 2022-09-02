using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_GroupBy
    {
        public static void Main()
        {
            List<string> words = new List<string>()
            { "basket","blueberry","cheese","apple","banana","abacus","chinpanze"};

            var wordGroups = words.GroupBy(x => x[0]).Select
                  (y => new { Fristletter = y.Key, words = y });


            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words that start with the" + "letter '{0}':" + item.Fristletter);

                foreach (var w in item.words)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
