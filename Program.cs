using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            char respostaJogo;
            int jogador = 0;
            int computador = 0;
            int somaDosNumeros = 0;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");



            do
            {
                Console.Write("Você quer par (p) ou ímpar (i)? ");
                string opcaoJogador = Console.ReadLine().ToLower();

                Console.Write("Informe um número inteiro: ");
                int numeroJogador = int.Parse(Console.ReadLine());

                Random roleta = new Random();
                int numeroComputador = roleta.Next(0, 11);


                if (opcaoJogador == "p")
                {
                    if (numeroJogador >= 0 && numeroJogador <= 10)
                    {
                        somaDosNumeros = numeroJogador + numeroComputador;
                        if ((somaDosNumeros % 2) == 0)
                        {
                            Console.WriteLine("Deu Par!");
                            jogador += 1;

                        }
                        else
                        {
                            Console.WriteLine("Deu Impar!");
                            computador += 1;
                        }
                    }

                }
                if (opcaoJogador == "i")
                {
                    if (numeroJogador >= 0 && numeroJogador <= 10)
                    {
                        somaDosNumeros = numeroJogador + numeroComputador;
                        if ((somaDosNumeros % 2) != 0)
                        {
                            Console.WriteLine("Deu Impar!");
                            jogador += 1;

                        }
                        else
                        {
                            Console.WriteLine("Deu Par!");
                            computador += 1;
                        }
                    }
                }
                else if (opcaoJogador != "p" && opcaoJogador != "i")
                {
                    Console.WriteLine("Numero Digitado Inválido!");
                    break;
                }

                Console.WriteLine("Você quer jogar de novo??  \n s (Sim) n (Não)");
                respostaJogo = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();

            } while (respostaJogo == 's');


            Console.WriteLine($" O computador ganhou {computador}x e o jogador ganhou {jogador}x.");

            if(jogador > computador)
            {
                Console.WriteLine("\n--O Jogador é o campeão.--");
            }
            else if (computador > jogador)
            {
                Console.WriteLine("\n--O Computador é o campeão--");
            }
            else
            {
                Console.WriteLine("\n-- O par ou impar deu empate --");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Aperte Enter para sair do programa");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
        }
    }
}