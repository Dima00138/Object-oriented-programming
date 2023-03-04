using System;
using Laba_3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    static class MainClass
    {
        static void Main()
        {
            bool end = false;
            int choice;
            Trains mass_elem;
            int arrLength = 1;
            string findName;
            int? findHour;
            int NumberForID = 21;
            int? takecol;
            Train<Trains> train = new Train<Trains>("Пункт 1", 3, 2233);

            do
            {
                Console.WriteLine("Главное меню\n" +
                    "1)Добавить поезд\n" +
                    "2)Посмотреть информацию о поезде\n" +
                    "3)Удалить поезд по индексу\n"
                    );
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        train.AddTrain(new Trains("Путь1", 3, 2100));
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Поезда в массиве");
                        mass_elem = new Trains("Путь1", 3, 2100);
                        Console.WriteLine(train.GetTrain(mass_elem));
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        train.DelTrain(index);
                        Console.WriteLine("\n");
                        break;
                    default: end = true;
                        break;
                }
            } while (!end);
            train.WriteInFile();
            train.ReadInFile();
        }
    }
}
