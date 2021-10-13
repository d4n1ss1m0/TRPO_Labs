using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Siniak
{
    class Program
    {
        static void Main(string[] args)
        {
            SiniakLog log = SiniakLog.I(); 
            Quadro eq = new Quadro();
            
            try
            {               
                log.log("Введите 3 параметра a,b,c");
                
                Console.Write("Введите a:");
                float a = (float) Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b:");
                float b = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c:");
                float c = (float)Convert.ToDouble(Console.ReadLine());
                

                log.log(String.Format("{0}x^2{1}x{2}=0", SignedNumber(a).Remove(0, 1), SignedNumber(b), SignedNumber(c)));
                var x =eq.Solve(a,b,c);               
                log.log(String.Format("Корни уравнения: x={0}  ", string.Join(" ", x)));
                
                
            }
            catch(SiniakException e)
            {
                log.log(e.Message);               
            }
            catch
            {
                log.log("Что-то пошло не так");
            }
            log.write();
            Console.ReadKey();
        }

        public static string SignedNumber(float num)//если число >= 0, добавить +, иначе -
        {
            string str = "";
            if (num < 0)
            {
                str += "-";
            }
            else
            {
                str += "+";
            }
            return str += num;
        }
    }
}
