using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Var3.CheckButton;

namespace Var3
{
    internal class Button
    {
        public string? caption;
        public (int, int) starpoint;
        public double w, h;

        public override string ToString()
        {
            return $"caption={caption}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Button button)
                return w == button.w && h == button.h;
            return false;
        }
    }
}
