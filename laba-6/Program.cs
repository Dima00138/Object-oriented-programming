using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal static class Program
    {
        static void Main()
        {
            Car MyCar = new Car(true, 140, 120000);
            Train MyTrain = new Train(4, 2000);
            Express MyExpress = new Express(2100);
            Car MyCar2 = new Car(25, 210, 250000);

            TransportAgency Agency = new TransportAgency();
            Agency.AddElement(MyCar);
            Agency.AddElement(MyTrain);
            Agency.AddElement(MyExpress);
            Agency.AddElement(MyCar2);

            Agency.PrintList();

            Agency.CostingTransport();

            Agency.DelElement(1);
            Agency.sortCarsByFuel();
            Agency.PrintList();

            Agency.SearchTransport(110, 150);


            try
             {
                 Car MyCar3 = new Car(-10, 50, 2000);
             }catch (CarException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             try
             {
                 Car MyCar3 = new Car(100, 20, 0);
             }
             catch (CarException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             try
             {
                 Train MyTrain2 = new Train(0, 200);
             }
             catch (TrainException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             try
             {
                 Train MyTrain2 = new Train(2, 0);
                Express MyExpress2 = new Express(-100);
            }
             catch (TrainException ex)
             {
                 Console.WriteLine(ex.Message);
             }
            catch (ExpressException ex)
            {
                Console.WriteLine(ex.Message);
            }


            ////sdsjnadsahjkjdfbs
            try
             {
                 Train MyTrain2 = new Train(2, 0);
                 Express MyExpress2 = new Express(-100);
             }
             catch
             {
                 Console.WriteLine("Возникла ошибка");
             }

             try
             {
                 Express MyExpress2 = new Express(-100);
             }
             catch (ExpressException ex)
             {
                 Console.WriteLine(ex.Message + " " + ex.Val + " " + ex.Source + " " + ex.Data);
             }
             finally
             {
                 Console.WriteLine("Будет выведено в любом случае");
             }

             //Проброс
             try
             {
                 Express MyExpress2 = new Express(50);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Возникла ошибка");
             }

             //Assert
             TransportAgency tr = new TransportAgency();
             tr.PrintList();
         }
        }
    }
