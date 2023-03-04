using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class Car : Transport
    {
        public enum MarkOfCar 
        {
            KIA,
            BMW,
            PEUGEOT
        }
        public double costSpeed;
        public bool convertible { get; set; }
        public int fuelCost;
        public MarkOfCar mark;
        public new const string? TypeTransport = "Автомобиль";

        public override void Start()
        {
            Console.WriteLine("Поехали");
        }

        public Car(int fuelCost, int speed, int cost) : base()
        {
            this.speed = speed;
            this.cost = cost;
            mark = MarkOfCar.PEUGEOT;
            if (fuelCost <= 0)
            {
                throw new CarException("Ошибка аргумента", fuelCost);
            }
            this.fuelCost = fuelCost;
            if (cost == 0)
            {
                throw new CarException("Деление на нуль");
            }
            costSpeed = Math.Round((double)speed / cost, 2);
        }

        public Car(bool _convertible, int _speed, int _cost)
        {
            convertible = _convertible;
            fuelCost = 15;
            speed = _speed;
            cost = _cost;
            mark = MarkOfCar.KIA;
        }

        public override string ToString()
        {
            return $"Объект - {typeof(Car)}, вид - {TypeTransport}, Кабриолет - {convertible}, потребление топлива - {fuelCost}" +
                $",\nскорость - {speed}, стоимость - {cost}, марка - {mark}";
        }
    }
}
