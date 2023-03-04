using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    public class Class1
    {
        public int baseValue;

        public Class1(int BaseValue)
        {
            this.baseValue = BaseValue;
        }
        public Class1()
        {
            baseValue = 0;
        }
        public int ItsP(int pre)
        {
            return pre * baseValue;
        }
    }
}
