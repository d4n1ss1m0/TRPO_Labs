using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Core;
using System.IO;

namespace Siniak
{
    class SiniakLog : LogAbstract, LogInterface
    {
        private static SiniakLog i;
        List<string> storage = new List<string>();

        private SiniakLog()
        {
            
        }

        public LogInterface Log(string str)
        {
            storage.Add(str);
            return this;
        }

        public LogInterface Write()
        {
            WriteConsole(storage.ToArray());
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\log";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllLines(path + "\\" + DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss.fff") + ".log", storage.ToArray());
            return this;
        }

        public static SiniakLog I()
        {
            if (i == null)
                i = new SiniakLog();
            return i;
        }
    }
}
