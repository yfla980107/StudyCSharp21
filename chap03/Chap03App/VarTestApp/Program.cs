﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        static float i = 100.5f;

        static void Main(string[] args)
        {
            var i = 100.5f;
            Console.WriteLine($"정수값은 {i} 입니다.");
        }
    }
}
