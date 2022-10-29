using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class TrainException : DivideByZeroException
    {
        public int Val { get; }
        public TrainException(string message, int val) : base(message) 
        {
            Val = val;
        }
    }
}
