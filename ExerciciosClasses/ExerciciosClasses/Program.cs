using System;
using System.Globalization;

namespace ExerciciosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //ex1:
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("nome: " + pessoa1.nome);
            Console.WriteLine("idade: " + pessoa1.idade);
            Console.WriteLine(" ");
            Console.WriteLine("Dados segund pessoa: ");
            Console.WriteLine("nome: " + pessoa2.nome);
            Console.WriteLine("idade: " + pessoa2.idade);
            Console.WriteLine(" ");
            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Mais velho: " + pessoa1.nome);
            }//fimIf
            else
            {
                Console.WriteLine("Mais velho: " + pessoa2.nome);
            }//fimelse
            //fimEx_1 */

            //ex2:
            Funcionarios funcionario1, funcionario2;
            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();

            Console.Write("Nome do funcionaerio: ");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Slario:");
            funcionario1.salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Nome do funcionaerio: ");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Slario:");
            funcionario2.salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            double mediaSalarial = (funcionario1.salario + funcionario2.salario)/2 ;

            Console.WriteLine("Media salarial: " + mediaSalarial);





        }//static void
    }//fimclass

}//namespace