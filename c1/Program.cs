using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 3, 5 };
            for (int i = 0; i < tablica.Length; i++) {
                Console.WriteLine("tablica[{0}] = {1}", i, tablica[i]);
            }
        }
    }
}
