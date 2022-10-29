using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class ExpressException : ArgumentException
    {
        public int Val { get; }
        public ExpressException(string message, int val = 0) : base(message)
        {
            Val = val;
        }


    }
}
