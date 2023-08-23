using System;
using System.Globalization;


namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //Console.ReadLine lê em forma de string;
            char ch = char.Parse(Console.ReadLine());
            double db = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' '); //Leu a linha toda, recortou os pedaços e salvou no vetor;
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);  
            double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);   
           
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(db);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}