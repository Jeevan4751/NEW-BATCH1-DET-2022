using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class IntroToLINQ
    {
        // three parts of a LINQ Query
        public static void  Main()
        {                                                                            
            //1.Data source
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(108);
            numbers.Add(102);
            numbers.Add(106);

            //2.Query creation sql type                                            //{deffered execution}

            //lamda exp
            // var numQuery = numbers.Select(x => x);

            //lamda exp
            var numQuery = numbers.Where(x => x > 102);
           // var numQuery = from num in numbers  //select num from numbers
                      //     where num>110
                        //   select num;

           /* var numQuery = (from num in numbers                                   //{early execution}
                           select num).ToList();*/

            numbers.Add(200);

            //3.Query eexecution

            foreach (int num in numQuery)
            {
                Console.Write (" {0} ",  num  );
                //num.duemp(): // this is for LINQpad not for VS
            }

            Console.ReadLine();
        }



        
    }
}
