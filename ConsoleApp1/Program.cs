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
            Quadro b = new Quadro();
            try
            {                
                b.Solve(0, 1, 1);
                
                log.log("x1=" + b.getX()[0].ToString());
                if(b.getX().Length>1)
                    log.log("x2=" + b.getX()[1].ToString());

                log.write();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
