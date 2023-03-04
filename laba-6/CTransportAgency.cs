using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal abstract class CTransportAgency
    {
        public int count { get; set; }
        public abstract Transport[] ArrObj { get; set; }
        public Transport[]? arrObj;
        protected CTransportAgency()
        {
            count = 0;
            arrObj = new Transport[10];
        }

        public void AddElement(Transport obj)
        {
            if (count == 0)
            {
                arrObj[0] = obj;
                count++;
                return;
            }
            arrObj[count] = obj;
            count++;
        }

        public void DelElement(int index)
        {
            if (count == 0 || arrObj == null) return;

            arrObj[index] = null;
            for (int i = index;i < count; i++)
            {
                arrObj[i] = arrObj[i + 1];
            }
            count--;
        }

        public void PrintList()
        {
            //macros
            //Debug.Assert(count <= 0, "Кол-во элементов равно нулю");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}) {arrObj[i]}");
            }
        }

            
    }
}
