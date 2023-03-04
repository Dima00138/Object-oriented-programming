using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TOEXAM
{
    [Serializable]
    public class Rectangle : IFigure
    {
        [JsonIgnore]
        public float x { get; set; }
        [JsonIgnore]
        public float y { get; set; }
        public float h { get; set; }
        public float l { get; set; }
        public string color { get; set; }
        public Rectangle()
        {
            x = 0;
            y = 0;
            h = 0;
            l = 0;
            color = "white";
        }
        public Rectangle(float _x, float _y, float _h) : this()
        {
            x = _x;
            y = _y;
            h = _h;
        }

        public Rectangle(float x, float y, float h, float l, string color) : this(x, y, h)
        {
            this.l = l;
            this.color = color;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Прямоугольник: x={x}, y={y}, h={h}, l={l}, color={color}");
        }

        public override string ToString()
        {
            return $"Прямоугольник: x={x}, y={y}, h={h}, l={l}, color={color}";
        }

        public static Rectangle operator +(Rectangle rec, int i)
        {
            return new Rectangle { x = rec.x, y = rec.y, color = rec.color, h = rec.h + i, l = rec.l + i };
        }

        public float Square()
        {
            return h * l;
        }


    }
}
