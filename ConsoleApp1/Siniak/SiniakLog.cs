using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Siniak
{
    class SiniakLog : LogAbstract, LogInterface
    {
        private static SiniakLog i;
        List<string> storage = new List<string>();

        private SiniakLog()
        {
            
        }

        public LogInterface log(string str)
        {
            storage.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(storage.ToArray());
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
