using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class TestEMP
{
        public static void Main()
        {
            EMP99 e = new EMP99(22825, "Manasa", new DateOnly(2021, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");
        }
    }
}
