using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var2
{
    internal class Group : IClearnable
    {
        public List<Stud> studs= new List<Stud>();

        public void AddEl(Stud stud) 
        { 
            studs.Add(stud);
        }

        public void PrintCol()
        {
            foreach (Stud stud in studs)
            {
                Console.WriteLine(stud);
            }
        }

        public void Clearn()
        {
            try
            {
                if (studs.Count == 0)
                    throw new Exception();
                studs.Clear();
            }
            catch 
            {
                Console.WriteLine("Лист пуст");
            }
        }
    }
}
