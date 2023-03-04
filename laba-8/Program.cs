using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace laba_8
{
    internal class Program
    {
        public static void Main()
        {
            void DisplayMessage(string message) => Console.WriteLine(message);
            User u1 = new User();



            u1.Upgrade += DisplayMessage;
            u1.Work += DisplayMessage;
            u1.RankUp(true);
            u1.Working();
            u1.RankUp(false);

            string str1 = "Hello world!";

            void DelE(string st1, int ind, Action<string, int> op) => op(st1, ind);
            Predicate<string> IsFirstH = (string s1) => s1.IndexOf('H') == 0;
            Func<string, string, int, string> Insert = (string s1, string s2, int i) => InsEl(s1, s2, i);

            DelE(str1, 10, DelElems);
            Console.WriteLine(str1);

            Console.WriteLine(IsFirstH(str1));
            Console.WriteLine(Insert(str1, "How", 4));


            void DelElems(string st1, int ind) => str1 = st1.Remove(ind);
            string InsEl(string st1, string st2, int ind) => str1.Insert(ind, st2);
            void ReplaceS(string st1, char c1, char c2) => str1.Replace(c1, c2);
            void Substr(string str1, int ind) => str1.Substring(ind);
            void IndexOfC(string str1, char c1) => str1.IndexOf(c1);

        }
    }
}
