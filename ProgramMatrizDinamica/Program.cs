using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMatrizDinamica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite as linhas e colunas da matriz respectivamente: ");
            string[] vetorMN = Console.ReadLine().Split(' ');
            int m = int.Parse(vetorMN[0]);
            int n = int.Parse(vetorMN[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.Write("\nDigite " + n + " valores para inserir na matriz: ");
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }


            Console.Write("\nDigite um número da matriz no qual queira saber a posição: ");
            int numX = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numX == matriz[i, j])
                    {
                        Console.WriteLine("\nPosição: " + i + ", " + j);
                        if (j < n - 1)
                        {
                            Console.WriteLine("A direita tem o número: " + matriz[i, j + 1]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("A esquerda tem o número: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima tem o número: " + matriz[i - 1, j]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo tem o número: " + matriz[i + 1, j]);
                        }
                    }
                }
            }


            int count = 0;
            Console.WriteLine("\nMatriz: ");
            foreach (int obj in matriz)
            {
                Console.Write(obj + " ");
                count++;
                if (count == n)
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }

            Console.ReadLine();
        }
    }
}
