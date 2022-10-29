using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    static class MainClass
    {
        static void Main()
        {
            bool end = false;
            int choice;
            int mass_elem;
            int arrLength = 1;
            string findName;
            int? findHour;
            int NumberForID = 21;
            int? takecol;
            Laba_3.Train[] TrainArr = new Laba_3.Train[100];

            do
            {
                Console.WriteLine("Главное меню\n" +
                    "1)Добавить поезд\n" +
                    "2)Посмотреть информацию о поезде\n" +
                    "3)Посмотреть общее колво мест в поезде\n" +
                    "4)Cписок поездов, следующих до заданного пункта назначения\n" +
                    "5)Cписок поездов, следующих до заданного пункта назначения и отправляющихся после заданного часа\n" +
                    "6)Информация о классе\n"
                    );
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TrainArr[arrLength] = new Laba_3.Train(ref NumberForID, out takecol);
                        TrainArr[arrLength].Interface();
                        arrLength++;
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Введите номер поезда в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (arrLength > mass_elem)
                        {
                            TrainArr[mass_elem].TotalAmountSeats();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Введите номер поезда в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (arrLength > mass_elem)
                        {
                            TrainArr[mass_elem].ShowInfo();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("Введите пункт назначения");
                        findName = Console.ReadLine();
                        for (int i = 1; i < arrLength; i++)
                        {
                            if (findName == TrainArr[i].Destination)
                                Console.WriteLine("Поезд с номером: " + i);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("Введите пункт назначения");
                        findName = Console.ReadLine();
                        Console.WriteLine("Введите час отправления");
                        findHour = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < arrLength; i++)
                        {
                            if (findName == TrainArr[i].Destination && findHour == TrainArr[i].DepartureTime)
                                Console.WriteLine("Поезд с номером: " + i);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        if (arrLength != 0)
                            Laba_3.Train.ClassInfo();
                        Console.WriteLine("\n");
                        break;
                    default:
                        break;
                }
            } while (!end);
        }
    }
}
