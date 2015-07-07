﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
    public class AmountException:Exception
    {
        public string EMessage { get; set; }
        public AmountException(string msg) 
        {
            EMessage = msg;       
        }

    }
}
