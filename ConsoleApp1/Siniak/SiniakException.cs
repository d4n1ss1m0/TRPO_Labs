using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniak
{
    class SiniakException:Exception
    {
        public SiniakException(string str) : base(str)
        {

        }

    }
}
