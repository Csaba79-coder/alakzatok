// See https://aka.ms/new-console-template for more information

using alakzatok;

var hatszog = new Hexagon(5);
var teglalap = new Rectangle(7, 3);
var negyzet = new Square(2);
var haromszog = new Triangle(11, 4);

Console.WriteLine($"Hatszög területe: " + $"{hatszog.Area()}");
Console.WriteLine($"Hatszög kerülete: " + $"{hatszog.Perimeter()}");
Console.WriteLine($"Téglalap területe: " + $"{teglalap.Area()}");
Console.WriteLine($"Téglalap kerülete: " + $"{teglalap.Perimeter()}");
Console.WriteLine($"Négyzet területe: " + $"{negyzet.Area()}");
Console.WriteLine($"Négyzet kerülete: " + $"{negyzet.Perimeter()}");
Console.WriteLine($"Háromszög területe: " + $"{haromszog.Area()}");
Console.WriteLine($"Háromszög kerülete: " + $"{haromszog.Perimeter()}");