using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Employee
    {
        private int id {  get; set; }   

        private string name { get; set; }

        private int age { get; set; }

        public Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public Employee() 
        {
            this.age = 0;
            this.id++;

        }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public virtual  void Work( )
        {
            Console.WriteLine( $"{name} is  working");
        }
    }
}
