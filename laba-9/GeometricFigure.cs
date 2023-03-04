using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_9
{
    internal class GeometricFigure<T> : IEnumerator
    {
        public T[] array;
        public int position = 0;

        public GeometricFigure(T[] array) => this.array = array;

        public T Current
        {
            get
            {
                if (position == 0 || position >= array.Length)
                    throw new ArgumentException();
                return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => position = 0;

        public override string ToString()
        {
            return $"{array[0]}";
        }
    }
}
