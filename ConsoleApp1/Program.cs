using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Core;
using System.IO;

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

                
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                if (!File.Exists($"{path}\\version.txt"))
                {
                    File.Create($"{path}\\version.txt");
                }
                FileStream fstream = File.OpenRead($"{path}\\version.txt");              
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Версия программы: {textFromFile}");
                log.Log("Введите 3 параметра a,b,c");

                Console.Write("Введите a:");
                float a = (float) Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b:");
                float b = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c:");
                float c = (float)Convert.ToDouble(Console.ReadLine());
                

                log.Log(String.Format("{0}x^2{1}x{2}=0", SignedNumber(a).Remove(0, 1), SignedNumber(b), SignedNumber(c)));
                var x =eq.Solve(a,b,c);               
                log.Log(String.Format("Корни уравнения: x={0}  ", string.Join(" ", x)));
                
                
            }
            catch(SiniakException e)
            {
                log.Log(e.Message);               
            }
            catch
            {
                log.Log("Что-то пошло не так");
            }
            log.Write();

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
