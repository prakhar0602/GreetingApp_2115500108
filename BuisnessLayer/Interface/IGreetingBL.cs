﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Interface
{
    public interface IGreetingBL
    {
        public string SimpleGreeting();
        public string GetGreeting(string? firstName, string? lastName);
    }
}
