﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostosClasseAtributosMetodos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return 2 * (Altura * Largura);
        }
        public double Diagonal()
        {
            return Math.Pow(Altura,2);
        }
    }
}
