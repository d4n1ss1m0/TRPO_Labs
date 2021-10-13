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
            B b = new B();
            try
            {
                b.Quadr(0, 1, 1);
                Console.WriteLine("D=" + b.getD());
                Console.WriteLine("x1="+b.getX());
                Console.WriteLine("x2=" + b.getX2());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
