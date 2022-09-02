using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NEW_BATCH1_DET_2022
{
    internal class PracticeIntroToLINQ
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1104);
            numbers.Add(1088);
            numbers.Add(1025);
            numbers.Add(1061);

           //var numQuery = from num in numbers
             //              select (num);
              var numQuery = numbers.Where(x => x > 1050);


            numbers.Add(1060);


          foreach(int num in numQuery)
            {
                Console.Write(" {0} ", num);
                
            }

            Console.ReadLine();
        }
    
    }
}
