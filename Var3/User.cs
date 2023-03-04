using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var3
{
    internal class User
    {
        public delegate void ForClick();
        public delegate void ForResize(int p);

        public event ForClick click;
        public event ForResize resize;

        public void Inv()
        {
            click?.Invoke();
            resize?.Invoke(12);
        }
    }
}
