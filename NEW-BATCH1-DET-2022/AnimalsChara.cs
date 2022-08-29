
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class AnimalsChara
    {
        public abstract class Animal
        {
            public String name { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
            public abstract string MakeSound();
        }
    }
}

