using CriandoClasse;
using System;
using System.Globalization;


Triangulo x, y;
x = new Triangulo(); //Objeto "x" da classe/tipo "Triangulo"
y = new Triangulo(); //Objeto "y" da classe/tipo "Triangulo"


Console.WriteLine("Entre com as medidas de X:");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas de Y:");
y.A = double.Parse(Console.ReadLine());
y.B = double.Parse(Console.ReadLine());
y.C = double.Parse(Console.ReadLine());

double p = (x.A + x.B + x.C) / 2;
double areaX = Math.Sqrt(p * (x.A) * (x.B) * (x.C));

p = (y.A + y.B + y.C) / 2;
double areaY = Math.Sqrt(p * (y.A) * (y.B) * (y.C));

Console.WriteLine("AREA X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("AREA Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("MAIOR: " + areaX);
}
else
{
    Console.WriteLine("MAIOR: " + areaY);
}
