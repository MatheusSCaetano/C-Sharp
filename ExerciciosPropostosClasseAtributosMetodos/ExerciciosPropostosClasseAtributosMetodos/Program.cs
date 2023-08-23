using ExerciciosPropostosClasseAtributosMetodos;
using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ExerciciosPropostosClassesAtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //EX1
            Retangulo r1;
            r1 = new Retangulo();

            Console.WriteLine("Digite a altura do retafgljo: ");
            r1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine( );
            Console.WriteLine("Digite a largura");
            r1.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine( );
            double area = r1.Area();
            Console.WriteLine("AREA = " + area );
            Console.WriteLine( );
            double perimetro = r1.Perimetro();
            Console.WriteLine("PERIMETRO: " + perimetro);
            Console.WriteLine();
            double diagonal =  r1.Diagonal();
            Console.WriteLine("Diagonal: " + diagonal);
            */

            //EX2 

            Funcionario f1;
            f1 = new Funcionario();

            Console.WriteLine("nOME: ");
            f1.Nome =Console.ReadLine();
            Console.WriteLine( );
            Console.WriteLine("salario bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine( );
            Console.WriteLine("digite o valor do impostp: ");
            f1.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine( );
            double salarioliquido = 0;
            f1.CalculoSalarioLiquido(salarioliquido);
            Console.WriteLine(f1);
            Console.WriteLine(" ");
            Console.WriteLine(" Digite a porcentagem de aumento do salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            double valorporcentagem = 0;
            f1.AumentarSalario(porcentagem,valorporcentagem);
            Console.WriteLine(" ");
            f1.CalculoSalarioLiquido(salarioliquido);
            Console.WriteLine(f1);

        }
    }
}