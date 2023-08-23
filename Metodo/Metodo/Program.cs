using System;
using System.Globalization;

namespace Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
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


            double areaX = x.Area();// parenteses para indicar que é um método;

            double areaY = y.Area();

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

        }
    }
}