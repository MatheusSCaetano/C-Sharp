using System;
using System.Globalization;


namespace ResolvendoProblemaSemOrientObj
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine(  "Entere com as medidadr triang X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entere com as medidadr triang Y ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;

            double areaX = Math.Sqrt(p*(p-xA) * (p-xB) * (p-xC));

             p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("aX = " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("aY = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior: "+ areaX.ToString("F4",CultureInfo.InvariantCulture));
            }
                else{
                Console.WriteLine("Maior: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            }


        }
    }
}