using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    partial class Train : Transport
    {
        public int numberOfVans { get; set; }
        public readonly int timeInWay;

        public override void Start()
        {
            Console.WriteLine("Поехали");
        }
    }
}
