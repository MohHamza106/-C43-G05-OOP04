using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Calculator
    {

        public static int Sum( int number1,int number2 ) 
        { 
            return number1 + number2;
        }
        public static int Sum(int number1, int number2,int number3)
        {
            return number1 + number2+number3;
        }
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

    }
}
