using System;

namespace TaskJunior3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfLines = 10;
            int numberOfColumns = 10;
            int firstValueRandom = 0;
            int finishValueRandom = 10;
            int valueMax = 0;

            int[,] matrix = new int[numberOfLines, numberOfColumns];

            Console.WriteLine("\n" + matrix.Length + " - кол-во элементов в самой матрице.\n\nМатрица: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(firstValueRandom, finishValueRandom);
                    Console.Write(matrix[i, j] + " ");

                    if (valueMax < matrix[i, j])
                    {
                        valueMax = matrix[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица в которой были заменены большие значения на - 0:\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == valueMax)
                    {
                        matrix[i, j] = 0;
                    }

                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
