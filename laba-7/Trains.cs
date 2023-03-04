using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    public class Trains
    {
        public string Destination { get; set; }
        public int NumberOfTrain { get; set; }
        public int DepartureTime { get; set; }

        public Trains(string Destination, int NumberOfTrain, int DepartureTime)
        {
            this.Destination = Destination;
            this.NumberOfTrain = NumberOfTrain;
            this.DepartureTime = DepartureTime;
        }
        public override string ToString()
        {
            return $"Путь - {Destination}, Кол-во вагонов - {NumberOfTrain}, Время пути - {DepartureTime}";
        }
    }
}
