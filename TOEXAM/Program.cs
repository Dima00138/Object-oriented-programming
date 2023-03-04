using System.Text.Json;
using System.Text.Json.Serialization;
using TOEXAM;

List<Rectangle> rectangles = new List<Rectangle>();

rectangles.Add(new Rectangle());
rectangles.Add(new Rectangle(10,20,50));
rectangles.Add(new Rectangle(10, 20, 40, 50, "red"));
rectangles.Add(new Rectangle(12, 21, 21));
rectangles.Add(new Rectangle(12, 22, 22));
rectangles.Add(new Rectangle(12, 23, 23));

rectangles[2] = rectangles[3] + 10;
rectangles[2].Print();
Console.WriteLine(rectangles[2].Square());


var linq = from r in rectangles
           orderby r.x ascending
           select r;
linq.First().Print();
linq.Last().Print();
var linq2 = from r in rectangles
           orderby r.y ascending
           select r;
linq2.First().Print();
linq2.Last().Print();
var linq3 = from r in rectangles
           orderby r.Square() ascending
           select r;
linq3.First().Print();
linq3.Last().Print();

string json = JsonSerializer.Serialize(rectangles);
Console.WriteLine(json);