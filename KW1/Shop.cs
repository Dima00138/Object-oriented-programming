using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop : ICompare
    {
        public string[]? name = new string[10];

        public bool CompareForCount(Shop el1, Shop el2)
        {
            if (el1.name.Length == el2.name.Length)
            {
                return true;
            }
            return false;
        }

        public string this[int index]
        {
            set
            {
                name[index] = value;
            }
            get
            {
                return name[index];
            }
        }
    }
}
