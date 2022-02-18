using System;

namespace AticidadeEsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            do
            {
                Console.WriteLine("Digite a quantidade de ordens: ");
                int quantOrdens = Convert.ToInt32(Console.ReadLine());
                char direcao = 'N';

                char[] comandos = new char[quantOrdens];

                for (int i = 0; i < quantOrdens; i++)
                {
                    do
                    {
                        Console.Write("Digite o comando " + i + " :");
                        comandos[i] = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (comandos[i] != 'D' && comandos[i] != 'E')
                        {
                            Console.WriteLine("\nDigite um comando válido.\n");
                        }
                    } while (comandos[i] != 'D' && comandos[i] != 'E');
                

                if (comandos[i] == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }
                if (comandos[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(direcao);
                Console.ResetColor();

                Console.ReadLine();
                
            } while (true);       
        }
        
    }
}