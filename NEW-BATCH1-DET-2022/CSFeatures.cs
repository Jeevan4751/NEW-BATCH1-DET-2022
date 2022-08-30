using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string>action=(string name) => {  Console.WriteLine($"hai{name}"); };
            Action<string , string> action1 = (string s1, string s2) => { Console.WriteLine($"tell{s1}, "+ $"you said {s2}"); };
            Action<string , string , string> action2 = (string empid ,string name ,string sal) => { Console.WriteLine($"Employee Id {empid},"+ $"Employee name {name},"+ $"Employee sal {sal}"); };


            action.Invoke("jeevan");
            action1.Invoke("hello", "employee");
            action2.Invoke("22857", "jeevan", "28800");
        }
    }
}
