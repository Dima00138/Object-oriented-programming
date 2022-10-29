using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Car : Transport
    {
        public bool convertible { get; set; }
        public new const string? TypeTransport = "Автомобиль";

        public override void Start()
        {
            Console.WriteLine("Поехали");
        }

        public Car() : base()
        {

        }

        public Car(bool _convertible)
        {
            convertible = _convertible;
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Car)}, вид - {TypeTransport}, Кабриолет - {convertible}";
        }
    }
}
