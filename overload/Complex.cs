using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Complex
    {
        public int real { get; set; }
        public int imag { get; set; }

        public static Complex operator +(Complex left, Complex Right)
        {
            return new Complex()
            {
                real = left.real + Right.real,
                imag = left.imag + Right.imag

            };

        }
        public static Complex operator -(Complex left, Complex Right)
        {
            return new Complex()
            {
                real = left.real - Right.real,
                imag = left.imag - Right.imag

            };

        }
        public override string ToString()
        {
            return $"{real}+{imag}i";
        }

    }
}
