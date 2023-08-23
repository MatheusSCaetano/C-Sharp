using System;
using System.Globalization;

namespace ObjectAndTostring
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); //Objeto "p" recebendo a classe Produto;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);// A quantidade digitada acima será o parâmetro utilazado na função que se encontra na class "Produto"
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine( );
            Console.WriteLine("Digite a quantidade a ser removida:");
            qtde = int.Parse(Console.ReadLine());   
            p.RemoverProdutos(qtde);
            Console.WriteLine( );
            Console.WriteLine("Dados do produto: " + p);






        }//Fim Main
    }//Fim class Program
}//Fim namespace