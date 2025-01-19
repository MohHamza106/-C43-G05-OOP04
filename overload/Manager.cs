using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Manager:Employee
    {
        private int Salary {  get; set; }

        public Manager(int salary ):base()
        {
            Salary = salary;
        }    

        public override void Work()
        {
            Console.WriteLine( $"Manager is managing ");
        }
    }
}
