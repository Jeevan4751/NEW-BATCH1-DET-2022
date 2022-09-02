using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class LINQ_ThenByDescending
    {
        public static void Main()
        {
          var dates = new DateTime[]
          {
            new DateTime(2015, 3, 5),
            new DateTime(2014, 7, 10),
            new DateTime(2013, 5, 16),
            new DateTime(2015, 1, 1),
            new DateTime(2015, 7, 11),
          };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month).ThenByDescending(d =>d.Day); ;

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
               Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }
    }
}
