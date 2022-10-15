// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Structures;

MyPoint p = new(3, -2);

MyPoint p2 = p;

// Console.WriteLine($"p.x {p.x}");
// Console.WriteLine($"p2.x {p2.x}");
//
// Console.WriteLine();
// p.x = 10;
// Console.WriteLine($"p.x {p.x}");
// Console.WriteLine($"p2.x {p2.x}");

var d = p.Distance(3, 4);
//Console.WriteLine(d);

StructPoint point = new StructPoint(5, 5);
var distance = point.Distance(1, 8);

StructPoint p1 = point;
Console.WriteLine($"point.x {point.x}");
Console.WriteLine($"p1.x {p1.x}");
point.x = 20;

Console.WriteLine($"point.x {point.x}");
Console.WriteLine($"p1.x {p1.x}");
//Console.WriteLine(distance);