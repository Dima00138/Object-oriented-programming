using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    partial class Train : Transport
    {
        public Van Vans;
        public new const string? TypeTransport = "Поезд";

        public Train(int _numberOfVans, int _timeInWay)
        {
            this.speed = 80;
            if (_numberOfVans == 0)
            {
                throw new TrainException("Деление на нуль", _numberOfVans);
            }

            numberOfVans = _numberOfVans;
            Vans = new Van(_count: _numberOfVans);
            cost = 60000 + _numberOfVans*10000;

            if (_timeInWay == 0)
            {
                throw new TrainException("Деление на нуль", _timeInWay);
            }
            timeInWay = _timeInWay;
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Train)}, вид - {TypeTransport}, колво вагонов - {numberOfVans}, время в пути - {timeInWay}" +
                $", скорость - {speed}, стоимость - {cost}";
        }
    }
}
