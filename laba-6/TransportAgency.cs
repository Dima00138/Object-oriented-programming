using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class TransportAgency : CTransportAgency
    {
        public TransportAgency():base() { }

        public override Transport[]? ArrObj { get => arrObj; set => arrObj = value; }
        public int totalCost = 0;

        public void CostingTransport()
        {
            for (int i = 0; i < count; i++)
            {
                totalCost += arrObj[i].cost;
            }
            Console.WriteLine("Общая стоимость: {0}", totalCost);
        }

        public void sortCarsByFuel()
        {
            Transport temp;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (arrObj[i].TypeTransport == "Автомобиль")
                    {
                        if (((Car)arrObj[i]).fuelCost > ((Car)arrObj[j]).fuelCost)
                        {
                            temp = arrObj[i];
                            arrObj[i] = arrObj[j];
                            arrObj[j] = temp;
                        }
                    }
                }
            }
        }

        public void SearchTransport(int minSpeed, int MaxSpeed)
        {
            Console.WriteLine("Транспорт соответсвующий требованиям скорости");
            for (int i = 0; i < count; i++)
            {
                if (arrObj[i].speed > minSpeed && arrObj[i].speed < MaxSpeed)
                {
                    Console.WriteLine(arrObj[i].ToString());
                }
            }
        }
    }
}
