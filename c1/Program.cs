using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int iloscLiczbParzystych = 0;
            int iloscLiczbNieparzystych = 0;
            foreach (int i in tablica) {
                
                if (i % 2 == 0)
                {
                    iloscLiczbParzystych++;
                }
                else {
                    iloscLiczbNieparzystych++;
                }
            }
            Console.WriteLine("Tablica zawiera {0} oraz {1}.", iloscLiczbParzystych, iloscLiczbNieparzystych);

        }
    }
}
