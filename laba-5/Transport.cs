using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal abstract class Transport : IEngine
    {
        public static string? TypeTransport { get; set; }
        private bool started { get; set; }

        public Transport()
        {
            TypeTransport = "Транспорт";
        }

        public abstract void Start();

        void IEngine.Start()
        {
            Console.WriteLine("Поплыли");
        }

        public void EngineOn()
        {
            started = true;
            Console.WriteLine("Машина заведена");
        }

        public void EngineOff()
        {
            started = false;
            Console.WriteLine("Машина заглушена");
        }

        public void Run()
        {
            EngineOn();
            Console.WriteLine("Машина поехала");
        }

        public void Stop()
        {
            EngineOff();
            Console.WriteLine("Машина остановилась");
        }

        public virtual string ToString(string obj)
        {
            return $"Тип транспортного средства - {TypeTransport}";
        }
    }
}
