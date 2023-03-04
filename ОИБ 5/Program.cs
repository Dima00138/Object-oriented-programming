using System;
using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;


namespace lab3
{

    class Man
    {

        public class Set
        {
            public string message;
            

            public Set(string x)
            {
                message = x;
            }
            public string MD()
            {
                using var provider = MD5.Create();
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(message)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }

            public int modpow(int bas, int exp, int modulus)
            {
                bas %= modulus;
                int result = 1;
                while (exp > 0)
                {
                    if (exp % 2 == 1) result = (result * bas) % modulus;
                    bas = (bas * bas) % modulus;
                    exp >>= 1;
                }
                return result;
            }

            public int Eiler(int p, int q)
            {
                return (p - 1) * (q - 1);
            }

        }




        public static void Main()
        {
            Console.WriteLine("Введите текст сообщения");
            string word = Console.ReadLine();
            Set set = new Set(word);
            string h = set.MD();
            Console.WriteLine($"Хеш-образ отправляемого сообщения: {h}");
            int p = 11, q = 31;
            int e = 257;
            int d = 11;
            while ((d * e - 1) % set.Eiler(p, q) != 0) d++;
            Console.WriteLine($"d= {d}");
            List<int> a = new List<int>();
            for (int i = 0; i < h.Length; i++)
            {
                a.Add(set.modpow((int)(h[i]), e, p * q));
            }
            Console.WriteLine($"Цифровой ключ: ");
            foreach (int b in a) Console.Write(b);
            Console.WriteLine(" ");
            char c = ' ';
            string H = "";
            for (int i = 0; i < h.Length; i++)
            {
                c = (char)(set.modpow(a[i], d, p * q));
                H += c;
            }
            Console.WriteLine($"Вычисление хеш-образа из полученной цифровой подписи: {H}");
            if (H == h && set.MD() == H) Console.WriteLine($"Цифровая подпись подтверждена");
        }
    }
}

