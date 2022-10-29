using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal static class Program
    {
        static void Main()
        {
            Car MyCar = new Car(true);
            Car MyCar1 = new Car();
            MyCar.Run();
            MyCar.Stop();
            MyCar.Start();
            ((IEngine)MyCar).Start();
            Console.WriteLine(MyCar.ToString());
            Console.WriteLine(MyCar1.ToString());

            Train MyTrain = new Train(4, 2000);
            MyTrain.Run();
            MyTrain.Stop();
            Console.WriteLine(MyTrain.ToString());

            Express MyExpress = new Express();
            MyExpress.Run();
            MyExpress.Stop();
            Console.WriteLine(MyExpress.ToString());

            IEngine obj = MyTrain as Transport;

            Console.WriteLine(obj.ToString());
            Console.WriteLine(MyTrain is IEngine);

            Printer print = new Printer();
            print.IAmPrinting(MyExpress);
        }
    }
}
