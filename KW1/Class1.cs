using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Main()
        {
            //a
            string str1 = "компания доч.";
            str1 = str1.Replace('о', 'а');
            str1 = str1.Replace("д", "дж");
            Console.WriteLine(str1);

            //b
            int[,] arr = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)  arr[i, j] = 0;
                    else arr[i, j] = 1;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            //2
            Shop shop1 = new Shop();
            Shop shop2 = new Shop();
            shop1.name = new string[2] { "1", "2"};
            shop2.name = new string[3] { "1", "2", "3" };
            if (shop1.CompareForCount(shop1, shop2))
                Console.WriteLine("Первый больше второго");
            else
                Console.WriteLine("Второй больше первого");

            //3
            Flash f1 = new Flash();
            f1.memory = 1024;
            Flash f2 = new Flash();
            f2.memory = 2048;
            f1.Write("Привет");
            Console.WriteLine(f1 == f2);
            Memory m1 = new Memory();
            Memory m2 = new Memory();
            m1.memory = 1024;
            m1 = m2;
            Console.WriteLine(m1 == m2);
            Electronic e1 = new Electronic();
            Electronic e2 = new Electronic();




        }
    }
       
}
