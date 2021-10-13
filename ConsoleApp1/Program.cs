using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            A a4 = new A();
            B b5 = new B();
            b5.a1 = a1; //и тд
            b5.a2 = a2;
            b5.a3 = a3;
            b5.a4 = a4;
        }
    }
}
