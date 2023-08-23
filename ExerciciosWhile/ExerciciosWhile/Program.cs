using System;
using System.Globalization;

namespace ExerciciosWhile
{
    class Program
    {
       /* static void Ex1(string[] args)
        {
             string senha = "2002";

             Console.WriteLine("Digite a senha: ");
             string verificacao = Console.ReadLine();

             while(senha != verificacao)
             {
                 Console.WriteLine("Senha inválida!");

                 Console.WriteLine("Digite a senha novamente:");
                 verificacao = Console.ReadLine();
                 Console.WriteLine(" ");
             }
             Console.WriteLine(" ");
             Console.WriteLine("Acesso permitido!");
         
        }*/
       /* static void Main (string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);


            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            
    
           }
        }*/
       static void Main(string[] args)
        {
            int etanol = 0, gasolina = 0, diesel =0;
            Console.WriteLine("[1] GASOLINA" );
            Console.WriteLine("[2] ETANOL");
            Console.WriteLine("[3] DIESEL");
            Console.WriteLine("[4] FIM");

            int idCombustivel = int.Parse(Console.ReadLine());

            while(idCombustivel != 4) { 
            while (idCombustivel < 1 || idCombustivel > 4)
            {
                Console.WriteLine("Número incorreto!! Digite o número novamente: ");
                Console.WriteLine("[1] GASOLINA");
                Console.WriteLine("[2] ETANOL");
                Console.WriteLine("[3] DIESEL");
                Console.WriteLine("[4] FIM");
                idCombustivel = int.Parse(Console.ReadLine());
            }
            if(idCombustivel == 1)
                {
                    gasolina = gasolina+1;
                }
            else if(idCombustivel == 2)
                {
                   etanol = etanol+1;
                }
                else
                {
                    diesel = diesel+1;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Vote novamente: ");
                Console.WriteLine("[1] GASOLINA");
                Console.WriteLine("[2] ETANOL");
                Console.WriteLine("[3] DIESEL");
                Console.WriteLine("[4] FIM");

                idCombustivel = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Obrigado pela contribuição!");
            Console.WriteLine("ETANOL: " + etanol);
            Console.WriteLine("GASOLINA: " + gasolina);
            Console.WriteLine("DIESEL " + diesel);
        }
    }
}

        
            
    
