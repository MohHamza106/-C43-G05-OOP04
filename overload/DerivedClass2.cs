﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class DerivedClass2: BaseClass

    {
        public new void DisplayMessage()
        {
            Console.WriteLine("DerivedClass2");
        }
    }
}
