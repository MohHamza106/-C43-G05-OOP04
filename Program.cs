using System.Diagnostics.CodeAnalysis;
using oop.overload;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //    int result;
            //    result = Calculator.Sum(45, 30);
            //    Console.WriteLine(result);
            #endregion
            #region 2
            //    Rectangle rectangle = new Rectangle(20);
            //    Console.WriteLine(rectangle);
            #endregion
            #region 3
            //Complex C1 = new Complex() { real = 20, imag = 4 };
            //Complex C2 = new Complex() { real = 50, imag = 5 };

            //Complex C3 = C2 + C1;
            //Complex C4 = C1 - C2;

            //Console.WriteLine($"C1  = {C1}");
            //Console.WriteLine($"C2  = {C2}");
            //Console.WriteLine("-----------");
            //Console.WriteLine($"C3  = {C3}");
            //Console.WriteLine($"C4  = {C4}");
            #endregion
            #region 4
            //    Employee employee = new Employee(20, "ahmed");
            //    employee.Work();
            //    Employee employe = new Manager(20);
            //    employe.Work();
            #endregion
            #region 5
            //    BaseClass baseClass1 = new DerivedClass1();
            //    baseClass1.DisplayMessage();
            //    BaseClass baseClass2 = new BaseClass();
            //    baseClass2.DisplayMessage();
            //    BaseClass baseClass3 = new DerivedClass2();
            //    baseClass3.DisplayMessage(); 
            #endregion
            #region part2
            Duration D = new Duration(1, 10, 15);
            Console.WriteLine(D);
            Duration D1 = new Duration(3600);
            Console.WriteLine(D1);
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);
            Duration D3 = new Duration(666);
            Console.WriteLine(D3);



            Console.WriteLine("-------------------------------------");

            Duration D4 = D1 + D2;
            Console.WriteLine(D4);

            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = ++D1;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);
            if (D1 > D2)
            {
                Console.WriteLine(D1);
            }
            else
            {
                Console.WriteLine(D2);
            }

            if (D1 <= D2)
            {
                Console.WriteLine(D2);
            }
            else
            {
                Console.WriteLine(D1);
            }
            if (D1 != null)
            {
                Console.WriteLine(true);
            }
            else { Console.WriteLine(false); }



            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);





            #endregion






        }
    }
}
