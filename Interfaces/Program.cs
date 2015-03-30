using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint1 emp1 = new Employee();
            IPrint2 emp2 = new Employee();
            emp1.Print1();
            emp2.Print2();

            Console.ReadLine();
        }
    }

    class Employee : IPrint1, IPrint2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }
        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }
    interface IPrint1
    {
        void Print1();
    }
    interface IPrint2
    {
        void Print2();
    }
}
