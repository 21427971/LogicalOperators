﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        //Logical operators..Boolean variables
        static void Main(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city);
            bool friendNeeds = (beach || hiking);
            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);
        }
    
    }
}
