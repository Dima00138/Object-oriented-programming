using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class ExpressException : CarException
    {
        public int Val { get; }
        public new string Source = "Source";
        public new string Data = "Data";
        public ExpressException(string message, int val = 0) : base(message)
        {
            Val = val;
        }


    }
}
