﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Interfaces;

namespace CreationalPatterns.Students
{
    class BadStudent:IStudent
    {
        public string Fio { get; set; }
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("I hate studying.");
        }
    }
}
