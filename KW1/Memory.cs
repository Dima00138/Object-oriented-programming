using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Memory : Electronic, IWrite
    {
        public int memory;
        public void Write(string str)
        {
            Console.WriteLine(str);
        }

        public static bool operator ==(Memory m1, Memory m2)
        {
            if (m1.memory == m2.memory) { return true; }
            return false;
        }
        public static bool operator !=(Memory m1, Memory m2)
        {
            if (m1.memory != m2.memory) { return true; }
            return false;
        }
    }
}
