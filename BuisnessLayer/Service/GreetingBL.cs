﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer.Interface;

namespace BuisnessLayer.Service
{
     public class GreetingBL:IGreetingBL
    {
        public string SimpleGreeting()
        {
            return "Hello World";
        }
    }
}
