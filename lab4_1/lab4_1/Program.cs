﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your data:");
            Data data = new Data(Console.ReadLine());
            data.DataType();
        }
    }
}
