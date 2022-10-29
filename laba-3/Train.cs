using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_3
{
    //Вариант 11
    partial class Train
    {
        const string TYPE = "Train";
        public static readonly int NumberForHash;
        private int Id { get; set; }
        public string Destination { get; set; }
        public int NumberOfTrain { get; set; }
        public int DepartureTime { get; set; }
        public struct SeatNumber
        {
            public int General { get; set; }
            public int Compartment { get; set; }
            public int ReservedSeat { get; set; }
            public int Suite { get; set; }
        }
        public SeatNumber Seats;

        static Train()
        { NumberForHash = 23; }

        public override int GetHashCode()
        {
            Random x = new Random();
            return Id * 3 * x.Next(123) * NumberForHash;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return true;
        }
        private Train(int Id, string Destination, int NumberOfTrain, int DepartureTime, SeatNumber structure)
        {
            this.Id = Id;
            this.Destination = Destination;
            this.NumberOfTrain = NumberOfTrain;
            this.DepartureTime = DepartureTime;
            this.Seats = structure;
        }

        public Train(ref int num, out int? res)
        {
            Id = num;
            Id = GetHashCode();
            res = Id;
        }

        protected float[] msf = new float[10];
        //индексатор
        public float this[int j]
        {
            get
            {
                return msf[j];
            }
            set
            {
                msf[j] = value;
            }
        }

        public static void ClassInfo()
        {
            Console.WriteLine("Статическая информация о классе");
            Console.WriteLine("Это класс поездов");
            Console.WriteLine("Его тип: " + TYPE);
        }

        public void TotalAmountSeats()
        {
            Console.WriteLine($"Общее число свободных мест {Seats.General}");
        }
        public void Interface()
        {
            Console.WriteLine("Ввести место назначения");
            Destination = Console.ReadLine();
            Console.WriteLine("Ввести номер поезда");
            NumberOfTrain = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести час отправления");
            DepartureTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести число общих мест");
            Seats.General = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Из них купе");
            Seats.Compartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("плацкарт");
            Seats.ReservedSeat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("люкс");
            Seats.Suite = Convert.ToInt32(Console.ReadLine());

        }

        public void ShowInfo()
        {
            Console.WriteLine(Destination + " - пункт назначения");
            Console.WriteLine(NumberOfTrain + " - номер поезда");
            Console.WriteLine(DepartureTime + " - время отправления");
            Console.WriteLine(Seats.General + " - общих мест из них {0} - купе, {1} - плацкарт, {2} - люкс", Seats.Compartment, Seats.ReservedSeat, Seats.Suite);
            Console.WriteLine(Id + " ID");
        }

        public override string ToString()
        {
            return $"{Destination}";
        }
    }
}
