using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

          /*  if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Bom dia");
          */
            if (x > 10)
            {
                Console.WriteLine("Boa tarde");
            }else if (x >= 10)
            {
                Console.WriteLine("Boa noitchê");
            }
            else
            {
                Console.WriteLine("Bom dia");
            }


            }
        }
    }
