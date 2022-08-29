

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class Company
{
    public string name { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public String faxnumber { get; set; }
    public CompanyManager Manager { get; set; }
        
     override public string ToString()
        {
            return $"name={name} ,address={address},phone= {phone},website= {website},faxnumber={faxnumber},Manager={Manager.ToString()}";
        }

}
}
