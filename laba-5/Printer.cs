using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Printer
    {
        public virtual void IAmPrinting(Transport someObj)
        {
            if (someObj is Transport)
                Console.WriteLine(typeof(Transport).ToString());
            if (someObj is Train)
                Console.WriteLine(typeof(Train).ToString());
            if (someObj is Car)
                Console.WriteLine(typeof(Car).ToString());
            if (someObj is Express)
                Console.WriteLine(typeof(Express).ToString());
            if (someObj is Van)
                Console.WriteLine(typeof(Van).ToString());
        }
    }
}
