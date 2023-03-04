using Laba_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal interface ITrain<T>
    {
        void AddTrain(T tr);
        void DelTrain(int number);
        int GetTrain(T tr);
    }
}
