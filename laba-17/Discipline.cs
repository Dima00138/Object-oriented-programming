using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17
{
    [Serializable]
    internal class Discipline
    {
        public enum Control
        {
            Exam,
            Zachet
        }
        public string name;
        public int semestr;
        public string course;
        public string spec;
        public int countLections;
        public int countLabs;
        public Control control;
        public Lector lector;
        
        public Discipline(Lector lector)
        {
            this.lector = lector;
        }
    }
}
