using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    internal class Program
    {
        public static void Main()
        {
            SuperList<int> sl = new SuperList<int>();
            sl.list.Add(1);
            sl.list.Add(2);
            sl.list.Add(3);
            try
            {
                Console.WriteLine(sl.Search(3));
                Console.WriteLine(sl.Search(5));
            }
            catch
            {
                Console.WriteLine("Элемент не найден");
            }

            //2
            string[] arr = {"abc", "b3", "c", "bdddd", "a2", "adhsdb"};
            var selectedStrings = from a in arr
                                  where a.Length == 2 && a[0] == 'a'
                                  select a;
            foreach (string a in selectedStrings)
            {
                Console.WriteLine(a);
            }

            //3
            Match m = new Match();

            Fan f1 = new Fan();
            Fan f2 = new Fan();

            m.EvGol += f1.Gol;
            m.EvGol += f2.Gol;

            m.GolT();
            m.GolT();
         }
    }
}
