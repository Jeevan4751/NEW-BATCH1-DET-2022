using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);
    }

    class BMW : ICar
    {


        public int GetPrice(string name)
        {
            if (name == "M3")
                return 15000000;
            else if (name == "X7")
                return 9600000;
            else
                return 4100000;
        }
    }
}