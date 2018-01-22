﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Interfaces
{
    interface IFactory
    {
        IStudent CreateStudent();
    }
}
