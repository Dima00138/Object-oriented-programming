using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    internal class SuperList<T>
    {
        public List<T> list = new List<T>();

        public int Search(T el)
        {
                if (list.IndexOf(el) == -1)
                {
                    throw new Exception();
                }
                else return list.IndexOf(el);
        }
    }
}
