using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] tablica = new int[2, 5];
            int counter = 1;
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 5; j++)
                {
                    tablica[i, j] = counter;
                    counter++;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("tablica[{0}, {1}] = {2}", i, j, tablica[i, j]);
                }
            }

            

        }
    }
}
