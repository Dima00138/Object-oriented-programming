using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal sealed class Express : Train
    {
        public new const string? TypeTransport = "Экспресс";
        public int speed { get; set; }

        public Express() : base (3, 5) 
        {
            speed = 120;
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Express)}, вид - {TypeTransport}, колво вагонов - {numberOfVans}, время в пути - {timeInWay}, скорость - {speed}";
        }
    }
}
