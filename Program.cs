using System;

namespace sort_matr_summa_strok
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] mas = new int[5, 7];
            Random random = new Random();
            int i, j;
            for (i = 0; i < 5; i++)
                for (j = 0; j < 7; j++)
                {
                    mas[i, j] = random.Next(0, 100);
                }

           
            Console.WriteLine("Вывод неотсортированной матрицы:");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // массив индексов
            Console.WriteLine("строки:");
            int[] index = new int[5];
            for (i = 0; i < 5; i++)
            {
                index[i] = i;
                Console.Write(i + "    ");
            }
            Console.WriteLine();

            // подсчет суммы строк
            int[] sum = new int[5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    sum[i] += mas[i, j];
                }
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            

            int[] sum1 = new int[5];
            sum.CopyTo(sum1, 0);
            Array.Sort(sum, index);

            Console.WriteLine("отсортированные строки:");
            for (i = 0; i < 5; i++)
            {
                Console.Write(index[i] + "    ");
            }
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.Write(sum[i] + " ");
            }


            int[,] mas2 = new int[5, 7];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    mas2[i, j] = mas[index[i], j];
                }
                
            }

            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("Вывод отсортированной матрицы:");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(mas2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}