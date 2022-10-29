using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class CarException : Exception
    {
        public int Val {get;}
        public CarException(string message, int val = 0) : base(message)
        {
            Val = val;
        }

    }
}
