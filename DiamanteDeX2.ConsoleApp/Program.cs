using System;

namespace DiamanteDeX2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoDiamante = 0;

            //Valor impar fornecido pelo usuario:
            while (tamanhoDoDiamante % 2 == 0)
            {
                Console.Write("Digite um numero impar: ");
                tamanhoDoDiamante = int.Parse(Console.ReadLine());
            }


            int quantidadeIncialEspacos = (tamanhoDoDiamante - 1) / 2;

            int quantidadeDeX = 1;

            int quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;

            DiamanteDeX(ref quantidadeIncialEspacos, ref quantidadeDeX, quantidadeDeLinhas);

            //metodo do diamante de X;
            static void DiamanteDeX(ref int quantidadeIncialEspacos, ref int quantidadeDeX, int quantidadeDeLinhas)
            {
                //parte de cima do diamante:
                for (int linha = 0; linha < quantidadeDeLinhas; linha++)
                {
                    for (int i = 0; i < quantidadeIncialEspacos; i++)
                    {
                        Console.Write(" ");
                    }

                    for (int i = 0; i < quantidadeDeX; i++)
                    {
                        Console.Write("x");
                    }

                    quantidadeIncialEspacos--;
                    quantidadeDeX += 2;
                    Console.WriteLine();
                }

                //parte de baixo:
                for (int linha = 0; linha <= quantidadeDeLinhas; linha++)
                {
                    for (int i = 0; i < quantidadeIncialEspacos; i++)
                    {
                        Console.Write(" ");
                    }

                    for (int i = 0; i < quantidadeDeX; i++)
                    {
                        Console.Write("x");
                    }

                    quantidadeIncialEspacos++;
                    quantidadeDeX -= 2;
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
