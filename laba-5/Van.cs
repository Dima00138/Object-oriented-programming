using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Van
    {
        public readonly int countOfSeats;
        public int count { get; set; }

        public Van[] Vans;
        public Van this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return Vans[index];
                else
                    throw new Exception("Выход за пределы массива");
            }
            set
            {
                if (index >= 0 && index < count)
                    Vans[index] = value;
            }
        }

        public Van(int _countOfSeats = 15, int _count = 1)
        {
            countOfSeats = _countOfSeats;
            count = _count;
            Vans = new Van[count];
        }

        public override string ToString()
        {
            return $"{countOfSeats}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
