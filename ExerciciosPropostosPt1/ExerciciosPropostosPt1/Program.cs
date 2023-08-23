using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ExerciciosPropostosPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //ex1
             Console.Write("Digite o primeiro número:"); 
             int n1 = int.Parse(Console.ReadLine());
             Console.Write("Digite o outro numero: ");
             int n2 = int.Parse(Console.ReadLine());
             Console.WriteLine(" ");
             int soma = n1 + n2;

             Console.WriteLine("SOMA: " + soma);
            */

            /* //ex2
             double pi = 3.14159;
             Console.WriteLine("Digite o raio do círculo: ");
             double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             double area = pi * (raio * raio);

             Console.WriteLine("AREA: " + area.ToString("F2",CultureInfo.InvariantCulture));
            */
            /*
             //ex3

             int n1 = int.Parse(Console.ReadLine());    
             int n2 = int.Parse(Console.ReadLine());
             int n3 = int.Parse(Console.ReadLine());
             int n4 = int.Parse(Console.ReadLine());

             int diferenca = (n1 * n2 - n3 * n4);

             Console.WriteLine(diferenca);
            */

            /*
            //ex4 
            Console.Write("Digite seu ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Digte o valor recebido por hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(" ");
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            double horasTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valorHora * horasTrab;

            Console.WriteLine("ID: " + id);
            Console.WriteLine("SALARY: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //ex5

            Console.WriteLine("Digite o ID da peça 1: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Valor unitário da peça:");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("  ");
            Console.WriteLine("Digite o ID da peça 2: ");
            int peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            int quantidade2 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Valor unitário da peça:");
            double valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double valorTotal = (quantidade2 * valor2) + (quantidade * valor);

            Console.WriteLine("VALOR A PAGAR: " + valorTotal.ToString("F2",CultureInfo.InvariantCulture));
            */

            //ex 6 
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

