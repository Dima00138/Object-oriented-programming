using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOEXAM
{
    internal interface IFigure
    {
        virtual void Print()
        {
            Console.WriteLine($"Прямоугольник: x=0, y=0, h=0, l=0, color=0");
        }
    }
}
