using System;
namespace Metodo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double Area() //fUNCTION QUE SERÁ O MÉTODO DE CÁLCULO DA ÁREA;
        {
            double p = (A + B + C) / 2;

            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }

    }
}
