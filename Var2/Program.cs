using Var2;

Stud st1 = new Stud();

Console.WriteLine(st1.Name);

Group grp1 = new Group();

grp1.AddEl(st1);
grp1.PrintCol();

grp1.AddEl(new Stud { Exams = new int[3] { 10, 10, 10 }, SpecSpec = Stud.Spec.mobile });
grp1.AddEl(new Stud { Exams = new int[3] { 4, 6, 3 }, SpecSpec = Stud.Spec.poit });
grp1.AddEl(new Stud { Exams = new int[3] { 2, 10, 0 }, SpecSpec = Stud.Spec.isit });
grp1.AddEl(new Stud { Exams = new int[3] { 8, 5, 7 }, SpecSpec = Stud.Spec.mobile });
grp1.AddEl(new Stud { Exams = new int[3] { 7, 5, 6 }, SpecSpec = Stud.Spec.poit });


var linq = from st in grp1.studs
           orderby st.Exams.Max()
           group st by st.SpecSpec;

var lin1 = from st in linq
           from st2 in st
           select new
           {
               st = st2,
               Exams = st2.Exams.Max()
           };

foreach(var gr in lin1)
        Console.WriteLine(gr.st.SpecSpec);