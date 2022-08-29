
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class CompanyManager
{
        public string name { get; set; }
        public string surename { get; set; }
        public string phone { get; set; }

       override public string ToString()
        {
            return $"name={name},surename={surename},phone={phone}";  
        }
}
}
