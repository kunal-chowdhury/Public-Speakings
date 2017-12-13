﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureAppDemo.Models
{
    public class Cart
    {
        public string ID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Rate { get; set; }
    }
}