using Var3;

CheckButton b1= new CheckButton();
CheckButton b2= new CheckButton();
CheckButton b3 = new CheckButton();
CheckButton b4 = new CheckButton();

User us = new User();

us.click += b1.Check;
us.click += b2.Check;
us.resize += b3.Zoom;
us.resize += b4.Zoom;

us.Inv();

Console.WriteLine($"{b1.state}, {b2.state}, {b3.state}, {b4.state}");

LinkedList<Button> list = new LinkedList<Button>();
b1.w = 10;
b2.w = 20;
b1.h= 30;
b2.h = 15;
list.AddLast(b1);
list.AddLast(b2);
list.AddLast(new Button { w=12,h=23});
list.AddLast(new Button { w=10,h=10});
var lin0 = list.Where(s => s.w*s.h == 300);
var lin1 = from b in list
           where b.w*b.h == 300
           select b;
foreach (Button b in lin0)
    Console.WriteLine(b);

var linq = from b in list
           where b is CheckButton
           select b;

foreach (Button b in linq)
    Console.WriteLine(b.GetType());