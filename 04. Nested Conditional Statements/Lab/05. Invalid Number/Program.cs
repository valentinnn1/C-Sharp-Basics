﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if ((num != 0) && ((num <= 99) || (num >= 201)))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
