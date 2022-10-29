using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    public static class Laba
    {
        public static void Main()
        {
            // 1
            // a
            bool BoolT = false;
            Console.WriteLine("bool: {0}\n", BoolT);

            sbyte SbyteT = 12;
            Console.WriteLine("sbyte: {0}\n", SbyteT);

            byte ByteT = 2;
            Console.WriteLine("byte: {0}\n", ByteT);

            short ShortT = 13;
            Console.WriteLine("short: {0}\n", ShortT);

            ushort UshortT = 34;
            Console.WriteLine("ushort: {0}\n", UshortT);

            int IntT = 14;
            Console.WriteLine("int: {0}\n", IntT);

            uint UintT = 345;
            Console.WriteLine("uint: {0}\n", UintT);

            long LongT = 15L;
            Console.WriteLine("long: {0}\n", LongT);

            ulong UlongT = 4757uL;
            Console.WriteLine("ulong: {0}\n", UlongT);

            float FloatT = 2.3F;
            Console.WriteLine("float: {0}\n", FloatT);

            double DoubleT = 3.454D;
            Console.WriteLine("double: {0}\n", DoubleT);

            char CharT = '\u0012';
            Console.WriteLine("char: {0}\n", CharT);

            // b
            ushort NeY1 = ByteT;
            Console.WriteLine("Неявное 1: {0}\n", NeY1);

            float NeY2 = ByteT;
            Console.WriteLine("Неявное 2: {0}\n", NeY2);

            double NeY3 = LongT;
            Console.WriteLine("Неявное 3: {0}\n", NeY3);

            int NeY4 = CharT;
            Console.WriteLine("Неявное 4: {0}\n", NeY4);

            float NeY5 = UshortT;
            Console.WriteLine("Неявное 5: {0}\n", NeY5);

            decimal Yav1 = (decimal)ByteT;
            Console.WriteLine("Явное 1: {0}\n", Yav1);

            decimal Yav2 = (decimal)DoubleT;
            Console.WriteLine("Явное 2: {0}\n", Yav2);

            char Yav3 = (char)ByteT;
            Console.WriteLine("Явное 3: {0}\n", Yav3);

            float Yav4 = (float)UshortT;
            Console.WriteLine("Явное 4: {0}\n", Yav4);

            decimal Yav5 = Convert.ToDecimal(FloatT);
            Console.WriteLine("Явное 5: {0}\n", Yav5);

            // c
            object o1 = ByteT;
            byte b1 = (byte)o1;

            object o2 = UshortT;
            ushort b2 = (ushort)o2;

            object o3 = DoubleT;
            double b3 = (double)o3;

            object o4 = FloatT;
            float b4 = (float)o4;

            object o5 = CharT;
            char b5 = (char)o5;

            // d
            var v1 = "34434";
            Type v1T = v1.GetType();
            Console.WriteLine("Тип v1: {0}\n", v1T);

            // e
            int? n1 = null;
            Console.WriteLine($"n1 = null\n");
            int n2 = n1 ?? 100;
            Console.WriteLine($"n2 = {n2}\n");

            // f
            //var d1 = 2.34D;
            //d1 = "2";

            // 2
            // a
            string str1 = "sds jt mdfndjng";
            string str2 = "sjdj dnfnjdjn";
            Console.WriteLine(String.Compare(str1, str2));

            //b
            string str3 = "sjndf fkmdjf dkfjd";
            Console.WriteLine(string.Concat(str1, str2, str3));
            Console.WriteLine(String.Copy(str1));
            Console.WriteLine(str1.Substring(6));
            for (int i = 0; i < 3; i++)
                Console.WriteLine(str1.Split(' ')[i]);
            Console.WriteLine(str1.Insert(10, str1.Substring(12)));
            Console.WriteLine(str1.Replace(str1.Substring(12), ""));
            Console.WriteLine($"Строка str1: {str1}");

            //c
            string str4 = "";
            string str5 = null;
            str5 = "sjhdshjd";
            Console.WriteLine(string.IsNullOrEmpty(str4));
            Console.WriteLine(string.IsNullOrEmpty(str5));
            Console.WriteLine(str4 == str5);

            //d
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("string 1");
            sb1.Insert(sb1.Length, "+1");
            sb1.Remove(3, 4);
            Console.WriteLine(sb1);

            // 3
            //a
            int[,] arr1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = i + j;
                    Console.Write("{0} ", arr1[i, j]);
                    if (j == 2)
                        Console.WriteLine();
                }

            //b
            string[] arrStr = new string[3] { "s1", "s2", "s3" };
            Console.WriteLine(arrStr.Length);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", arrStr[i]);
            }
            Console.WriteLine();
            string strbsd = Console.ReadLine();
            int strPosit = Convert.ToInt32(strbsd);
            string strP = Console.ReadLine();
            arrStr[strPosit] = strP;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", arrStr[i]);
            }

            //c
            double[][] jaggedFloatArr = new double[3][];
            jaggedFloatArr[0] = new double[2];
            jaggedFloatArr[1] = new double[3];
            jaggedFloatArr[2] = new double[4];

            for (int j = 0; j < 2; j++)
                jaggedFloatArr[0][j] = Convert.ToDouble(Console.ReadLine());
            for (int j = 0; j < 3; j++)
                jaggedFloatArr[1][j] = Convert.ToDouble(Console.ReadLine());
            for (int j = 0; j < 4; j++)
                jaggedFloatArr[2][j] = Convert.ToDouble(Console.ReadLine());

            //d
            var que3d = new object[2];
            que3d[0] = "dkjfdjfdj";
            que3d[1] = 102;
            Console.WriteLine($"{que3d[0]}, {que3d[1]}");

            //4
            //a
            (int, string, char, string, ulong) c1 = (12, "sd", '2', "dsjdf", 923284938482938428L);

            //b
            Console.WriteLine($"Элем1 - {c1.Item1}, элем3 - {c1.Item3}, элем5 - {c1.Item5}");

            //c
            int intC3 = c1.Item1;
            string strC31 = c1.Item2;
            char charC3 = c1.Item3;
            string strC32 = c1.Item4;
            ulong longC3;

            (_, _, _, _, longC3) = c1;

            Console.WriteLine(longC3);

            //d
            var c2 = c1;
            Console.WriteLine($"c2 == c1 {c2==c1}, c2 != c1 {c2!=c1}");

            //5
            (int?, int?, int?, char) func1(int[] intArr, string strF)
            {
                int sum = 0, min = int.MaxValue, max = int.MinValue;
                for (int i = 0; i < intArr.Length; i++)
                    sum += intArr[i];
                for (int i = 0; i < intArr.Length; i++)
                {
                    if (min > intArr[i])
                        min = intArr[i];

                    if (max < intArr[i])
                        max = intArr[i];
                }
                return (max, min, sum, strF[0]);
            }
            int[] sdsa = { 2, 4, 5, 7, 232, -322, 34 };
            Console.WriteLine(func1(sdsa, "skdkjs"));

            //6
            void func2()
            {
                try
                {
                    int int123 = int.MaxValue;
                    checked
                    {
                        Console.WriteLine(int123 + 1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            func2();

            void func3()
            {
                try
                {
                    int int123 = int.MaxValue;
                    unchecked
                    {
                        Console.WriteLine(int123 + 1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            func3();

        }
    }
}
