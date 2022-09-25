using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1, p2, p3, p4;
            int QuantidadePositiva = 0;
            int QuantidadeNegativa = 0;
            int QuantidadeNaoAvaliada = 0;
            int total = 3;

            Console.Title = "Desafio GRX - Vinicius Valentim";
            Console.WriteLine("\tDesafio coleta - GRX ");

            #region Pergunta 1
            Console.WriteLine("\n1 - Você se considera bom em lógica?\n(sim ou não)");
            Console.ForegroundColor = ConsoleColor.Blue;
            p1 = Console.ReadLine().ToLower();

            while (p1 != "sim" && p1 != "nao")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido\nInsira novamente:");
                Console.ForegroundColor = ConsoleColor.Blue;
                p1 = Console.ReadLine().ToLower();
                

            }

            switch (p1)
            {
                case "sim":
                    QuantidadePositiva++;
                    break;
                case "nao":
                    QuantidadeNegativa++;
                    break;
            }
            #endregion

            #region Pergunta 2
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n2 - Gosta de aprender com desafios?\n(sim ou não)");
            Console.ForegroundColor = ConsoleColor.Blue;
            p2 = Console.ReadLine().ToLower();


            while (p2 != "sim" && p2 != "nao")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido\nInsira novamente:");
                Console.ForegroundColor = ConsoleColor.Blue;
                p2 = Console.ReadLine().ToLower();


            }

            switch (p2)
            {
                case "sim":
                    QuantidadePositiva++;
                    break;
                case "nao":
                    QuantidadeNegativa++;
                    break;
            }
            #endregion

            #region Pergunta 3
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n3 - Gostaria de fazer parte da GRX?\n(sim, não, não sei ou agora)");
            Console.ForegroundColor = ConsoleColor.Blue;
            p3 = Console.ReadLine().ToLower();


            while (p3 != "sim" && p3 != "nao" && p3 != "nao sei" && p3 != "agora")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido\nInsira novamente:");
                Console.ForegroundColor = ConsoleColor.Blue;
                p3 = Console.ReadLine().ToLower();
                

            }

            switch (p3)
            {
                case "sim":
                    QuantidadePositiva++;
                    break;

                case "nao":
                    QuantidadeNegativa++;
                    break;

                case "nao sei":
                    QuantidadeNaoAvaliada++;
                    break;

                case "agora":
                    QuantidadePositiva = QuantidadePositiva + 2;
                    total = 4;
                    break;
                default:
                    break;
            }
            #endregion

            #region Pergunta 4
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine();
                Console.WriteLine("\n4 - Por favor, justifique sua resposta:\n(Mínimo 15 e Máximo 200) ");
                Console.ForegroundColor = ConsoleColor.Blue;
                p4 = Console.ReadLine().ToLower();
            }
            while (p4.Length < 15 || p4.Length > 200);
            #endregion

            #region Pontuação
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-------------------PONTOS---------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Positivo -  {QuantidadePositiva}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Negativo -   {QuantidadeNegativa}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Nao avaliado - {QuantidadeNaoAvaliada}\n\n\n");

            #endregion

            #region Porcentagem
            Console.ForegroundColor = ConsoleColor.White;
            int PorPositivo = (QuantidadePositiva * 100) / total;           
            int PorNegativo = (QuantidadeNegativa * 100) / total;
            int PorNaoAvaliado = (QuantidadeNaoAvaliada * 100) / total;

            
            Console.WriteLine($"\t\tTOTAL\n\t\t  {total}\n");          
            Console.WriteLine($"Quantidade Positiva      {PorPositivo}%\n\t{QuantidadePositiva}\n");
            Console.WriteLine($"Quantidade Negativa      {PorNegativo}%\n\t{QuantidadeNegativa}\n");
            Console.WriteLine($"Quantidade Nao avaliada  {PorNaoAvaliado}%\n\t{QuantidadeNaoAvaliada}\n");

            #endregion

            Console.ReadKey();

        }
    }
}
