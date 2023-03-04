using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    internal class Match
    {
        public delegate void GolHandler();
        public event GolHandler? EvGol;
        public int gol = 0;
        public void GolT()
        {
            gol++;
            EvGol?.Invoke();
        }
    }
}
