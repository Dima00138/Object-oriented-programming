using System.Collections;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Var3
{
    public static class Prog
    {
        public static void Main(string[] args)
        {
            SomeString str = new SomeString();
            SomeString str2 = new SomeString();

            str.Str = "Str1";
            str2.Str = str.Str;

            str = str + "1";
            str = str - "t";

            str= str + "2.ds 2.--4 34.fd;dfd";
            str.Deliter();

            /*var linq = from st in s
                       select st.CounterSpace();

            foreach (var st in linq)
                Console.WriteLine(st);*/


            FileInfo fileInf = new FileInfo(@"D:\content.txt");

            using (StreamWriter sw = new StreamWriter(@"D:\content.txt"))
            {
                sw.WriteLine(str.Equals(str2));
                sw.WriteLine(str.Compare(str, str2));
                sw.WriteLine(str.Str);
                sw.WriteLine(str.CounterSpace());
            }
        }
    }

    public class SomeString : IComparer
    {
        public String Str { get; set; }

        public int Compare(object? x, object? y)
        {
            if (x is SomeString x1 && y is SomeString y1) 
            {
                return x1.Str.Length - y1.Str.Length;
            }
            return 0;
        }

        public override bool Equals(object? obj)
        {
            if (obj.GetType() != typeof(SomeString))
                return false;
            SomeString objec = obj as SomeString;
            return Str.Length == objec.Str.Length && Str[0] == objec.Str[0] && Str[Str.Length - 1] == objec.Str[Str.Length - 1];
        }

        public static SomeString operator +(SomeString s1, string s2)
        {
            return new SomeString { Str = s1.Str + s2 };
        }

        public static SomeString operator -(SomeString s1, string s2)
        {
            try
            {
                if (s1.Str.Length == 0)
                {
                    throw new Exception();
                }
                return new SomeString { Str = s1.Str.Substring(1) };
            }
            catch 
            {
                Console.WriteLine("Пусто");
                return new SomeString();
            }
        }
    }

    public static class SSExtern
    {
        public static int CounterSpace(this SomeString s)
        {
            int counter = 0;
            for (int i = 0; i < s.Str.Length; i++)
            {
                if (s.Str[i].Equals(' '))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void Deliter(this SomeString s)
        {
            char[] chars = { '.', ',', '!', ';', ':', '-' };
            foreach (var c in chars)
            {
                s.Str = s.Str.Replace(c, '\0');
            }
        }
    }
}