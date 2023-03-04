using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Var5
{
    internal class Prog
    {
        public static void Main()
        {
            Own own = new Own();
            own.Name = "Test";
            own.Temp = 120;
            own.Time = 2.40f;
            Console.WriteLine(own.Status);

            Own[] owns = new Own[4];

            owns[0] = own;
            owns[1] = new Own { Temp = 100, Time = 13.3f };
            owns[2] = new Own { Temp = 0, Time = 10 };
            owns[3] = new Own { Temp = 22, Time = 120 };

            Task t1 = Task.Run(() =>
            {
                ((ICook)owns[0]).Cook();
            });
            Task t2 = Task.Run(() =>
            {
                ((ICook)owns[1]).Cook();

            });
            Task t3 = Task.Run(() =>
            {
                ((ICook)owns[2]).Cook();
            });
            Task t4 = Task.Run(() =>
            {
                ((ICook)owns[3]).Cook();
            });


            var linq = from o in owns
                       where o.Status == Own.Cook.cooking
                       select o;
            Console.WriteLine("------");
            try
            {
                if (linq.Count() == 0)
                {
                    throw new NotWorkingException("Not Work");
                }
            }
            catch (NotWorkingException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var o in linq)
            {
                Console.WriteLine(o.Status);
            }
            using (FileStream sw = new FileStream(@"D:\js.json", FileMode.OpenOrCreate)) 
            {
                JsonSerializer.SerializeAsync(sw, own);
            }
        }
    }

    [Serializable]
    abstract class Unit
    {
        public string Name { get; set; }
    }

    [Serializable]
    class Own : Unit, ICook
    {
        public enum Cook
        {
            ready,
            cooking,
            finish
        }
        public int Temp { get; set; }
        public float Time { get; set; }

        [NonSerialized]
        public Cook Status = Cook.ready;

        [OnDeserialized]
        public void OnDes()
        {
            ((ICook)this).Check();
        }

        void ICook.Cook()
        {
            ((ICook)this).Check();
            if (!File.Exists(@"D:/file2.txt"))
                File.Create(@"D:/file2.txt");
            using (StreamWriter sw = new StreamWriter(@"D:/file2.txt"))
            {
                sw.WriteLine($"Status: {Status}");
            }
        }

        void ICook.Check()
        {
            if (Temp == 0 && Time > 0)
            {
                Status = Cook.ready;
            }
            if (Temp > 0 && Time > 0)
            {
                Status = Cook.cooking;
            }
            if (Temp > 0 && Time == 0)
            {
                Status = Cook.finish;
            }
        }
    }
    interface ICook
    {
        void Cook();
        void Check();
    }

    class NotWorkingException : Exception 
    {
        public NotWorkingException(string message) :base(message) {}
    }
}