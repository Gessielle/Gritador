using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string Família;

            Console.Write("Digite olá");
            Família = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{Família}!!!".ToUpper());

            Console.WriteLine("Pressione Enter para sair");
            Console.ReadKey();

        }
    }
}
