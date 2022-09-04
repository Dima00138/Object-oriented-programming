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

            decimal Yav5 = (decimal)FloatT;
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
        }
    }
}
