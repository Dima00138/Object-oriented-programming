using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Train : Transport
    {
        public int numberOfVans { get; set; }
        public readonly int timeInWay;
        public Van Vans;
        public new const string? TypeTransport = "Поезд";

        public override void Start()
        {
            Console.WriteLine("Поехали");
        }

        public Train(int _numberOfVans, int _timeInWay)
        {
            numberOfVans = _numberOfVans;
            timeInWay = _timeInWay;
            Vans = new Van(_count: _numberOfVans);
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Train)}, вид - {TypeTransport}, колво вагонов - {numberOfVans}, время в пути - {timeInWay}";
        }
    }
}
