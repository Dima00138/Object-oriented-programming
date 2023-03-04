using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var3
{
    internal class CheckButton : Button
    {
        public enum State
        {
            checked1,
            unchecked2
        }
        public State state;

        public void Check()
        {
            state = (state == State.checked1) ? State.unchecked2 : State.checked1;
        }

        public void Zoom(int p)
        {
            w = w * (p/100);
            h = h * (p/100);
        }
    }
}
