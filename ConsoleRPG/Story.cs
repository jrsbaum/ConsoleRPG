using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Story
    {
        public static void BeforeFirstFight()
        {
            string nome = null;

            Console.ReadKey();
            Console.WriteLine("------------Bem vindo------------");
            Console.ReadKey();
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}. Você esta caminhando por uma floresta para salvar o Reino de um ataque de um Dragão!");
            Console.ReadKey();
            Console.WriteLine("Enquanto você está a caminho, você encontra alguns bandidos");
            Console.ReadKey();
            Console.WriteLine("E eles não parecem ser amigáveis......");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeKnights()
        {
            Console.WriteLine("Os bandidos eram fracos demais. Agora você tem a missão de derrotas os 2 cavalheiros");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeDragons()
        {
            Console.WriteLine("Agora sim, você chegou aos temíveis dragões");
            Console.ReadLine();
            Console.Clear();
        }

        public static void TheEnd()
        {
            Console.WriteLine("Você matou os dragões e salvou o Reino!");
            Console.WriteLine("Parabéns!");
            Console.ReadLine();
        }
    }
}
