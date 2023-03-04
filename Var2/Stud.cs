using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var2
{
    internal class Stud
    {
        public enum Spec
        {
            poit,
            isit,
            mobile
        } 
        public string? Name {get; set;}
        public int Group { get; set;}
        public int Course { get; set;} 
        public Spec SpecSpec { get; set;}

        public int[] Exams { get; set;}

        public Stud()
        {
            Name = "none";
            Group = 0;
            Exams = new int[3] {4,4,7 };
            Course= 0;
            SpecSpec = Spec.mobile;
        }

        public (int, int, double) Quest2()
        {
            return (Exams.Max(), Exams.Min(), Exams.Average());
        }
    }
}
