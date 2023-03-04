using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal sealed class Express : Train
    {
        public struct TypeExpress
        {
            public string type;
            public int distance;

            public TypeExpress() {
                type = "df";
                distance = 0;
            }
        }
        public TypeExpress express;
        public new const string? TypeTransport = "Экспресс";

        public Express(int _distance) : base (3, 5) 
        {
            speed = 120;
            express.type = "Дальнего следования";
            if (_distance < 0)
            {
                throw new ExpressException("Неправильное значение переменной", _distance);
            }
            try
            {
                if (_distance > 0 && _distance < 100)
                {
                    throw new TrainException("Деление на 0", _distance);
                }
                express.distance = _distance;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Проброс");
                throw;
            }
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Express)}, вид - {TypeTransport}, колво вагонов - {numberOfVans}, время в пути - {timeInWay}," +
                $"\nскорость - {speed}, стоимость - {cost}, тип - {express.type}, длина пути - {express.distance}км";
        }
    }
}
